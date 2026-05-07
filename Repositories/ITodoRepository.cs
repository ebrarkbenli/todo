using TodoApi.Models;

namespace TodoApi.Repositories;

public interface ITodoRepository
{
    Task<List<Todo>> GetAllAsync();
    Task<Todo?> GetByIdAsync(int id);
    Task AddAsync(Todo todo);
    Task UpdateAsync(Todo todo);
    Task DeleteAsync(Todo todo);
    Task SaveChangesAsync();
    Task<List<Todo>> GetCompletedAsync();
    Task<List<Todo>> GetPendingAsync();

}