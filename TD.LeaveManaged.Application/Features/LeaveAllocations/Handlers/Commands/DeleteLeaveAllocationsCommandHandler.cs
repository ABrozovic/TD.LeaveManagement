using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs.LeaveAllocation.Validators;
using TD.LeaveManaged.Application.Exceptions;
using TD.LeaveManaged.Application.Features.LeaveAllocations.Requests.Commands;
using TD.LeaveManaged.Application.Persistence.Contracts;

namespace TD.LeaveManaged.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class DeleteLeaveAllocationsCommandHandler : IRequestHandler<DeleteLeaveAllocationsCommand>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        

        public DeleteLeaveAllocationsCommandHandler(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;            
        }
        public async Task<Unit> Handle(DeleteLeaveAllocationsCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteLeaveAllocationDtoValidator();
            var validationResult = await validator.ValidateAsync(request.Id);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

                        
            var leaveAllocation = await _leaveAllocationRepository.Get(request.Id);
            if (leaveAllocation == null)
                throw new NotFoundException(nameof(leaveAllocation), request.Id);

            await _leaveAllocationRepository.Delete(leaveAllocation);
            return Unit.Value;
        }
    }
}
