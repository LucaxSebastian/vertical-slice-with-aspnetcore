using MediatR;
using Microsoft.AspNetCore.Mvc;
using vertical_slice_with_aspnet.VerticalSliceTodoList.Features_TodoItems.Commands;

namespace vertical_slice_with_aspnet.VerticalSliceTodoList.Controllers;

[ApiController]
[Route("todo")]
[Produces("application/json")]
public class TodoController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    public async Task<IActionResult> AddTodoItem([FromBody] AddTodoItemCommand command, CancellationToken cancellation = default)
    {
        var result = await _mediator.Send(command, cancellation);

        //return result.ToActionResult(
        //    onSucess: result =>
        //    {
        //        return new CreatedAtActionResult(
        //            nameof(GetTodoItem), "todo", new { id = result.Value }, result.Value);
        //    });
    }

}
