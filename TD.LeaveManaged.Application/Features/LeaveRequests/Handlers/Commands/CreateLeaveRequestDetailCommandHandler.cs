using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.Features.LeaveRequests.Requests.Commands;
using TD.LeaveManaged.Application.Persistence.Contracts;
using TD.LeaveManagement.Domain;

namespace TD.LeaveManaged.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestDetailCommandHandler:IRequestHandler<CreateLeaveRequestDetailCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestDetailCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveRequestDetailCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = _mapper.Map<LeaveRequest>(request.leaveRequestDto);
            leaveRequest= await _leaveRequestRepository.Add(leaveRequest);
            return leaveRequest.Id;
        }
    }
}
