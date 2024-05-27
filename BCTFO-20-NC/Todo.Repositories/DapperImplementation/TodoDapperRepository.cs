using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq.Expressions;
using Todo.Contracts;
using Todo.Data;
using Todo.Entities;

namespace Todo.Repositories.DapperImplementation
{
    public class TodoDapperRepository : ITodoRepository
    {
        private readonly DapperContext _context;
        public TodoDapperRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task AddTodoAsync(TodoEntity entity)
        {
            string sqlExpression = "sp_CreateTodo";

            using (var connection = _context.CreateConnection())
            {
                DynamicParameters parameters = new();
                parameters.Add(name: "title", entity.Title);
                parameters.Add(name: "description", entity.Description);
                parameters.Add(name: "startDate", entity.StartDate);
                parameters.Add(name: "endDate", entity.EndDate);
                parameters.Add(name: "status", entity.Status);
                parameters.Add(name: "userId", entity.UserId);

                var result = await connection.ExecuteAsync(sqlExpression, parameters, transaction: null, commandTimeout: null, CommandType.StoredProcedure);
            }

        }

        public async void DeleteTodo(TodoEntity entity)
        {
            string sqlExpression = "sp_DeleteTodo";

            using (var connection = _context.CreateConnection())
            {
                DynamicParameters parameters = new();
                parameters.Add(name: "id", entity.Id);

                var result = await connection.ExecuteAsync(sqlExpression, parameters, transaction: null, commandTimeout: null, CommandType.StoredProcedure);
            }
        }

        public async Task<List<TodoEntity>> GetAllTodosAsync()
        {
            string sqlExpression = "sp_AllTodos";

            using (var connection = _context.CreateConnection())
            {
                var products = await connection.QueryAsync<TodoEntity>(sqlExpression, null, commandType: CommandType.StoredProcedure);
                return products.ToList();
            }
        }

        public async Task<List<TodoEntity>> GetAllTodosAsync(Expression<Func<TodoEntity, bool>> filter)
        {
            string sqlExpression = "sp_AllTodos";
            List<TodoEntity> result = new();

            using (var connection = _context.CreateConnection())
            {
                var products = await connection
                    .QueryAsync<TodoEntity>(sqlExpression, null, commandType: CommandType.StoredProcedure) as IQueryable<TodoEntity>;

                if (products.Count() > 0)
                    result = await products.Where(filter).ToListAsync();
            }

            return result;
        }

        public async Task<TodoEntity> GetSingleTodoAsync(Expression<Func<TodoEntity, bool>> filter)
        {
            string sqlExpression = "sp_AllTodos";
            TodoEntity result = new();

            using (var connection = _context.CreateConnection())
            {
                var products = await connection
                    .QueryAsync<TodoEntity>(sqlExpression, null, commandType: CommandType.StoredProcedure) as IQueryable<TodoEntity>;

                if (products.Count() > 0)
                    result = await products.FirstOrDefaultAsync(filter);
            }

            return result;
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateTodoAsync(TodoEntity entity)
        {
            string sqlExpression = "sp_UpdateTodo";

            using (var connection = _context.CreateConnection())
            {
                DynamicParameters parameters = new();
                parameters.Add(name: "id", entity.Id);
                parameters.Add(name: "title", entity.Title);
                parameters.Add(name: "description", entity.Description);
                parameters.Add(name: "startDate", entity.StartDate);
                parameters.Add(name: "endDate", entity.EndDate);
                parameters.Add(name: "status", entity.Status);
                parameters.Add(name: "userId", entity.UserId);

                var result = await connection.ExecuteAsync(sqlExpression, parameters, transaction: null, commandTimeout: null, CommandType.StoredProcedure);
            }
        }
    }
}
