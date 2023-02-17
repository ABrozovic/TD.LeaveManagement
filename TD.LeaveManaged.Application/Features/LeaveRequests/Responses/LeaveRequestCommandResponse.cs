using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.Responses;

namespace TD.LeaveManaged.Application.Features.LeaveRequests.Responses
{
    public class LeaveRequestCommandResponse : BaseCommandResponse { 
        public int Id { get; set; }
    }
}
