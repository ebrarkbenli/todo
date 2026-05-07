using TodoApi.Models;

namespace TodoApi.TodoUpdateDto;

public class TodoUpdateDto
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Priority Priority { get; set; } 
    public DateTime DueDate { get; set; }
}