using TodoApi.Models;

namespace TodoApi.TodoResponseDto;

public class TodoResponseDto
{
    public int Id { get; set;}
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Priority Priority { get; set; } 
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }
    public DateTime DueDate { get; set; }
}