using System.Linq.Expressions;
using Todo.Entities;

namespace Todo.Contracts
{
    public interface ITodoRepository : ISavable
    {
        Task<List<TodoEntity>> GetAllTodosAsync();
        Task<List<TodoEntity>> GetAllTodosAsync(Expression<Func<TodoEntity, bool>> filter);
        Task<TodoEntity> GetSingleTodoAsync(Expression<Func<TodoEntity, bool>> filter);
        Task AddTodoAsync(TodoEntity entity);
        Task UpdateTodoAsync(TodoEntity entity);
        void DeleteTodo(TodoEntity entity);
    }
}
