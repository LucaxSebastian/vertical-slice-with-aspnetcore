namespace vertical_slice_with_aspnet.VerticalSliceTodoList.Domain;

public class TodoItem(string title)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Title { get; private set; } = title;
    public bool IsCompleted { get; private set; } = false;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; private set; }
    public DateTime? DeletedAt { get; private set; }

    public void Update(string title)
    {
        Title = title;
        UpdatedAt = DateTime.UtcNow;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Delete() => DeletedAt = DateTime.UtcNow;
}