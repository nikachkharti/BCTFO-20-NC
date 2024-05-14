using Todo.Models;

namespace Todo.Contracts
{
    public interface ITodoService
    {
        Task<List<TodoForGettingDto>> GetTodosOfUserAsync(string userId);
        Task<TodoForGettingDto> GetTodoByIdAsync(int id);
        Task DeleteTodoAsync(int id);
        Task AddTodoAsync(TodoForCreatingDto todoForCreatingDto);
        Task UpdateTodoAsync(TodoForUpdatingDto todoForUpdatingDto);
    }
}
