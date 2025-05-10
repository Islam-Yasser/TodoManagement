using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManagement.Todo;

namespace TodoManagement.Validations;

public class TodoValidation : AbstractValidator<CreateUpdateTodoDto>
{
    public TodoValidation()
    {
        RuleFor(x => x.Title)
        .NotEmpty().WithMessage("Title Can't be null")
        .MaximumLength(100).WithMessage("Title Length Must be less than or equal 100 characters");

        RuleFor(x => x.DueDate)
         .Must(d => d == null || d.Value.Date > DateTime.Today)
         .WithMessage("Due date must be later than today.");


    }
}
