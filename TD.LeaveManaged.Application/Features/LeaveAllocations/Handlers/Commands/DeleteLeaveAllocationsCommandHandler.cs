using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.Features.LeaveAllocations.Requests.Commands;
using TD.LeaveManaged.Application.Persistence.Contracts;

namespace TD.LeaveManaged.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class DeleteLeaveAllocationsCommandHandler : IRequestHandler<DeleteLeaveAllocationsCommand>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveAllocationsCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            this._leaveAllocationRepository = leaveAllocationRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveAllocationsCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.Get(request.Id);
            await _leaveAllocationRepository.Delete(leaveAllocation);
            return Unit.Value;
        }
    }
}
