using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManagement.Domain;

namespace TD.LeaveManaged.Application.Persistence.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
    }
}
