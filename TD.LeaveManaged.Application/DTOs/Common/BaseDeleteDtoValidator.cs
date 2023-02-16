using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.LeaveManaged.Application.DTOs.Common
{
    internal class BaseDeleteDtoValidator : AbstractValidator<int>
    {
        public BaseDeleteDtoValidator()
        {
            RuleFor(x => x).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
