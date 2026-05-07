using TodoApi.Data;
using TodoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Repositories;

public class TodoRepository : ITodoRepository
{
    private readonly AppDbContext _context;

    public TodoRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<Todo>> GetAllAsync()
    {
        return await _context.Todos.ToListAsync();
    }
    public async Task<Todo?> GetByIdAsync(int id)
    {
        return await _context.Todos.FindAsync(id);
    }
    public async Task AddAsync(Todo todo)
    {
        await _context.Todos.AddAsync(todo);
    }
    public Task UpdateAsync(Todo todo)
    {
        _context.Todos.Update(todo);

        return Task.CompletedTask;
    }
    public Task DeleteAsync(Todo todo)
    {
        _context.Todos.Remove(todo);

        return Task.CompletedTask;
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    public async Task<List<Todo>> GetCompletedAsync()
    {
        return await _context.Todos
            .Where(x => x.IsCompleted)
            .ToListAsync();
    }
    public async Task<List<Todo>> GetPendingAsync()
    {
        return await _context.Todos
            .Where(x => !x.IsCompleted)
            .ToListAsync();
    }
}