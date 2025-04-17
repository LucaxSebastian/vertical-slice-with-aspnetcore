using FluentResults;
using MediatR;
using System.Runtime.CompilerServices;
using vertical_slice_with_aspnet.VerticalSliceTodoList.Domain;
using vertical_slice_with_aspnet.VerticalSliceTodoList.Features_TodoItems.Commands;
using vertical_slice_with_aspnet.VerticalSliceTodoList.Infrastructure.Data;

namespace vertical_slice_with_aspnet.VerticalSliceTodoList.Features_TodoItems.CommandHandlers;

public class AddTodoItemCommandHandler(TodoItemDbContext context) : IRequestHandler<AddTodoItemCommand, Result<Guid>>
{
    private readonly TodoItemDbContext _context = context;

    public async Task<Result<Guid>> Handle(AddTodoItemCommand request, CancellationToken cancellationToken)
    {
        var todoItem = new TodoItem(request.Title);

        await _context.TodoItems.AddAsync(todoItem, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return Result.Ok(todoItem.Id);
    }
}

