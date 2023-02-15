using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs;

namespace TD.LeaveManaged.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationWithDetailRequest: IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
