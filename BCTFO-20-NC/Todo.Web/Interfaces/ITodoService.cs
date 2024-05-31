using Todo.Web.Models;

namespace Todo.Web.Interfaces
{
    public interface ITodoService
    {
        Task<ApiResponse> GetTodosOfUserAsync(string userId);
        Task<ApiResponse> GetTodoOfUserAsync(string userId, int todoId);
        Task<ApiResponse> AddTodoAsync(TodoForCreatingDto todoForCreatingDto);
        Task<ApiResponse> DeleteTodoAsync(int todoId);
    }
}
