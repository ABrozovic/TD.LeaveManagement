using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.LeaveManaged.Application.DTOs.Common;

namespace TD.LeaveManaged.Application.DTOs.LeaveType.Validators
{
    public class DeleteLeaveTypeDtoValidator : AbstractValidator<int>
    {
        public DeleteLeaveTypeDtoValidator()
        {            
            Include(new BaseDeleteDtoValidator());
        }
    }
} 
