using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs.LeaveRequest;

namespace TD.LeaveManaged.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestDetailRequest: IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
