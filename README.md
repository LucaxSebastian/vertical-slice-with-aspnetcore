# 🧱 Vertical Slice Architecture with ASP.NET Core

This project is a practical example of a simple TODO List API built with ASP.NET Core, applying the principles of Vertical Slice Architecture.

# 📌 Objective

Instead of dividing the application by traditional layers (Controllers, Services, Repositories...), Vertical Slice Architecture groups everything related to a specific functionality (like creating, listing, or deleting tasks) in one place. Each feature is treated as an isolated "slice".

# 🛠️ Technologies

- ASP.NET Core
- MediatR
- Entity Framework


# 📁 Project Structure

```
/VerticalSliceTodoList
  /Controllers
    TodoController.cs
  /Features
    /TodoItems
      /Commands
        AddTodoItemCommand.cs
        UpdateTodoItemCommand.cs
        MarkAsTodoItemCommand.cs
        DeleteTodoItemCommand.cs
      /Queries
        GetTodoListQuery.cs
        GetTodoItemQuery.cs
  /Domain
    TodoItem.cs
  /Infrastructure
    TodoDbContext.cs
```

# 🧠 Benefits

- Feature-based organization

- Reduced coupling between components

- Easier to understand and maintain code

- Simplifies scaling and testing individual features