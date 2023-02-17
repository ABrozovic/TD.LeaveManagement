using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs.LeaveRequest;
using TD.LeaveManaged.Application.Features.LeaveRequests.Responses;

namespace TD.LeaveManaged.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestDetailCommand :IRequest<LeaveRequestCommandResponse>
    {
        public CreateLeaveRequestDto leaveRequestDto { get; set; }
    }
}
