using FluentValidation;
using vertical_slice_with_aspnet.VerticalSliceTodoList.Features_TodoItems.Commands;

namespace vertical_slice_with_aspnet.VerticalSliceTodoList.Features_TodoItems.Validators;

public class AddTodoItemCommandValidator : AbstractValidator<AddTodoItemCommand>
{
    public AddTodoItemCommandValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(100);
    }
}
