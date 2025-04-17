using FluentResults;
using MediatR;
using vertical_slice_with_aspnet.VerticalSliceTodoList.Domain;

namespace vertical_slice_with_aspnet.VerticalSliceTodoList.Features_TodoItems.Queries;

public record GetTodoItemQuery : IRequest<Result<TodoItem>>
{
    public Guid Id { get; init; }
}

