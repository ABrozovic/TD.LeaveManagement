using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManagement.Domain;

namespace TD.LeaveManaged.Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetail(int Id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetail();

        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approvalStatus);
    }
}
