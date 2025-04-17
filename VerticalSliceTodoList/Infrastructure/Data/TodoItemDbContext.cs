using Microsoft.EntityFrameworkCore;
using vertical_slice_with_aspnet.VerticalSliceTodoList.Domain;

namespace vertical_slice_with_aspnet.VerticalSliceTodoList.Infrastructure.Data;

public class TodoItemDbContext : DbContext
{
    public TodoItemDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems  { get; set; }
}

