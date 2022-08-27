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
            RuleFor(v => v.RFC)
                .NotEmpty().WithMessage("RFC is required.")
                .Matches(@"/^([A-ZÑ&]{3,4}) ?(?:- ?)?(\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])) ?(?:- ?)?([A-Z\d]{2})([A\d])$/").WithMessage("RFC invalid.");
        }
    }
}
