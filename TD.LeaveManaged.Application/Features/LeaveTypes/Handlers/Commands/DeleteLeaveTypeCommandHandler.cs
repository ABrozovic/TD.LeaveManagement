using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs.LeaveType.Validators;
using TD.LeaveManaged.Application.Exceptions;
using TD.LeaveManaged.Application.Features.LeaveTypes.Requests.Commands;
using TD.LeaveManaged.Application.Persistence.Contracts;

namespace TD.LeaveManaged.Application.Features.LeaveTypes.Handlers.Commands
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;        

        public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;            
        }
        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.Id);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            var leaveType = await _leaveTypeRepository.Get(request.Id);

            if(leaveType == null)
                throw new NotFoundException(nameof(leaveType), request.Id);

            await _leaveTypeRepository.Delete(leaveType);
            return Unit.Value;
        }
    }
}
