using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs;
using TD.LeaveManaged.Application.DTOs.LeaveAllocation;

namespace TD.LeaveManaged.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand: IRequest<int>
    {
        public CreateLeaveAllocationDto leaveAllocationDto { get; set; }
    }
}
