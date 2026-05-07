using TodoApi.Models;

namespace TodoApi.TodoCreateDto;

public class TodoCreateDto
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Priority Priority { get; set; } 
    public DateTime DueDate { get; set; }
} 