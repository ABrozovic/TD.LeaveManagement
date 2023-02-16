using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs;
using TD.LeaveManaged.Application.DTOs.LeaveType;

namespace TD.LeaveManaged.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand: IRequest<int>
    {   
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
