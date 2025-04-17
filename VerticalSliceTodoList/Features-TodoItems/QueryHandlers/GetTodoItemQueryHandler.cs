using FluentResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using vertical_slice_with_aspnet.VerticalSliceTodoList.Domain;
using vertical_slice_with_aspnet.VerticalSliceTodoList.Features_TodoItems.Queries;
using vertical_slice_with_aspnet.VerticalSliceTodoList.Infrastructure.Data;

namespace vertical_slice_with_aspnet.VerticalSliceTodoList.Features_TodoItems.QueryHandlers;

public class GetTodoItemQueryHandler(TodoItemDbContext context) : IRequestHandler<GetTodoItemQuery, Result<TodoItem>>
{
     private readonly TodoItemDbContext _context = context;

    public async Task<Result<TodoItem>> Handle(GetTodoItemQuery request, CancellationToken cancellationToken)
    {
        var todoItem = await _context.TodoItems.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (todoItem is null)
            return Result.Fail("Todo item not found.");

        return Result.Ok(todoItem);
    }
}

