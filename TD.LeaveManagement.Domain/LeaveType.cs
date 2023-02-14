using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManagement.Domain.Common;

namespace TD.LeaveManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {        
        public string Name { get; set; }
        public int DefaultDays { get; set; }        
    }
}
