using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.LeaveManaged.Application.DTOs.LeaveRequest.Validators
{
    public class ChangeLeaveRequestApprovalDtoValidator:AbstractValidator<ChangeLeaveRequestApprovalDto>
    {
        public ChangeLeaveRequestApprovalDtoValidator()
        {
            RuleFor(x => x.Approved).NotNull().WithMessage("{PropertyName} must be present");
            RuleFor(x =>x.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
