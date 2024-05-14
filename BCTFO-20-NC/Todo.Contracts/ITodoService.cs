using Todo.Models;

namespace Todo.Contracts
{
    public interface ITodoService
    {
        Task<List<TodoForGettingDto>> GetTodosOfUserAsync(string userId);
        Task<TodoForGettingDto> GetSingleTodoByUserId(int todoId, string userId);
        Task DeleteTodoAsync(int id);
        Task AddTodoAsync(TodoForCreatingDto todoForCreatingDto);
        Task UpdateTodoAsync(TodoForUpdatingDto todoForUpdatingDto);
    }
}
