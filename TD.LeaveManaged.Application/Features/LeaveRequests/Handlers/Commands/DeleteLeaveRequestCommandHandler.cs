using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs.LeaveRequest.Validators;
using TD.LeaveManaged.Application.Exceptions;
using TD.LeaveManaged.Application.Features.LeaveRequests.Requests.Commands;
using TD.LeaveManaged.Application.Persistence.Contracts;

namespace TD.LeaveManaged.Application.Features.LeaveRequests.Handlers.Commands
{
    public class DeleteLeaveRequestCommandHandler:IRequestHandler<DeleteLeaveRequestCommand>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;        

        public DeleteLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;            
        }

        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteLeaveRequestDtoValidator();
            var validationResult = await validator.ValidateAsync(request.Id);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            var leaveRequest = await _leaveRequestRepository.Get(request.Id);
            if (leaveRequest == null)
                throw new NotFoundException(nameof(leaveRequest), request.Id);

            await _leaveRequestRepository.Delete(leaveRequest);
            return Unit.Value;
        }
    }
}
