using AutoMapper;
using Todo.Contracts;
using Todo.Entities;
using Todo.Models;
using Todo.Service.Exceptions;

namespace Todo.Service.Implementations
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;
        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
            _mapper = MappingInitializer.Initialize();
        }

        public async Task AddTodoAsync(TodoForCreatingDto model)
        {
            if (model is null)
                throw new ArgumentNullException("Invalid argument passed");

            var result = _mapper.Map<TodoEntity>(model);
            await _todoRepository.AddTodoAsync(result);
            await _todoRepository.Save();
        }

        public async Task DeleteTodoAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid argument passed");

            var result = await _todoRepository.GetSingleTodoAsync(x => x.Id == id);

            if (result == null)
                throw new TodoNotFoundException();

            _todoRepository.DeleteTodo(result);
            await _todoRepository.Save();
        }

        public async Task<List<TodoForGettingDto>> GetAllTodosAsync()
        {
            var raw = await _todoRepository.GetAllTodosAsync();

            if (raw.Count == 0)
                throw new TodoNotFoundException();

            var result = _mapper.Map<List<TodoForGettingDto>>(raw);
            return result;
        }

        public async Task<TodoForGettingDto> GetSingleTodoAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid argument passed");

            var raw = await _todoRepository.GetSingleTodoAsync(x => x.Id == id);

            if (raw == null)
                throw new TodoNotFoundException();

            var result = _mapper.Map<TodoForGettingDto>(raw);
            return result;
        }

        public async Task UpdateTodoAsync(TodoForUpdatingDto model)
        {
            if (model is null)
                throw new ArgumentNullException("Invalid argument passed");

            var result = _mapper.Map<TodoEntity>(model);
            await _todoRepository.UpdateTodoAsync(result);
            await _todoRepository.Save();
        }
    }
}
