using FluentResults;
using MediatR;

namespace vertical_slice_with_aspnet.VerticalSliceTodoList.Features_TodoItems.Commands;

public record AddTodoItemCommand : IRequest<Result<Guid>>
{
    public string Title { get; set; } = string.Empty;
}

