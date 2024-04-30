using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Linq;
using System.Linq.Expressions;
using Todo.Contracts;
using Todo.Data;
using Todo.Entities;

namespace Todo.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly ApplicationDbContext _context;
        public TodoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddTodoAsync(TodoEntity entity)
        {
            if (entity != null)
            {
                await _context.Todos.AddAsync(entity);
            }
        }

        public void DeleteTodo(TodoEntity entity)
        {
            if (entity != null)
            {
                _context.Todos.Remove(entity);
            }
        }

        public async Task<List<TodoEntity>> GetAllTodosAsync()
        {
            return await _context.Todos.ToListAsync();
        }

        public async Task<List<TodoEntity>> GetAllTodosAsync(Expression<Func<TodoEntity, bool>> filter)
        {
            return await _context.Todos
                .Where(filter)
                .ToListAsync();
        }

        public async Task<TodoEntity> GetSingleTodoAsync(Expression<Func<TodoEntity, bool>> filter)
        {
            return await _context.Todos.FirstOrDefaultAsync(filter);
        }

        public async Task Save() => await _context.SaveChangesAsync();

        public async Task UpdateTodoAsync(TodoEntity entity)
        {
            if (entity != null)
            {
                var todoToUpdate = await _context.Todos.FirstOrDefaultAsync(x => x.Id == entity.Id);

                if (todoToUpdate != null)
                {
                    todoToUpdate.Title = entity.Title;
                    todoToUpdate.Descrtiption = entity.Descrtiption;
                    todoToUpdate.StartDate = entity.StartDate;
                    todoToUpdate.EndDate = entity.EndDate;
                    todoToUpdate.Status = entity.Status;
                    todoToUpdate.Priority = entity.Priority;

                    _context.Todos.Update(todoToUpdate);
                }

            }
        }
    }
}
