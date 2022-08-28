using FluentValidation;

namespace Employees.Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(v => v.Name)
                .NotEmpty().WithMessage("Name is required.");
            RuleFor(v => v.LastName)
                .NotEmpty().WithMessage("Last name is required.");
            RuleFor(v => v.BornDate)
                .NotEmpty().WithMessage("Born date is required.")
                .Must(ValidateDate).WithMessage("Invalid born date.");
            RuleFor(v => v.RFC)
                .Matches(@"^[A-Za-zñÑ&]{3,4}\d{6}\w{3}$").WithMessage("RFC invalid.")
                .NotEmpty().WithMessage("RFC is required.");
        }

        public bool ValidateDate(DateTime bornDate) 
        {
            if (bornDate < DateTime.Now)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
    }
}
