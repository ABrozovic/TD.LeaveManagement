using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.LeaveManaged.Application.Features.LeaveAllocations.Requests.Commands
{
    public class DeleteLeaveAllocationsCommand :IRequest
    {
        public int Id { get; set; }
    }
}
