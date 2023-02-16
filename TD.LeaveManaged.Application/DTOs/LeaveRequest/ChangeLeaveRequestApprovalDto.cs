using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs.Common;

namespace TD.LeaveManaged.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {
        public bool? Approved { get; set; }
    }
}
