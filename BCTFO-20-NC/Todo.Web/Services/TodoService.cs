using Microsoft.Extensions.Configuration;
using Todo.Web.Interfaces;
using Todo.Web.Models;

namespace Todo.Web.Services
{
    public class TodoService : ITodoService
    {
        private readonly IBaseService _baseService;
        private readonly string _apiUrl;
        public TodoService(IBaseService baseService, IConfiguration configuration)
        {
            _baseService = baseService;
            _apiUrl = configuration.GetValue<string>("ServiceUrls:TodoApiUrl");

        }

        public async Task<ApiResponse> AddTodoAsync(TodoForCreatingDto todoForCreatingDto)
        {
            var result = await _baseService.SendAsync(new ApiRequest()
            {
                ApiType = ApiType.POST,
                Url = $"{_apiUrl}todos",
                Data = todoForCreatingDto
            });

            return result;
        }

        public async Task<ApiResponse> DeleteTodoAsync(int todoId)
        {
            var result = await _baseService.SendAsync(new ApiRequest()
            {
                ApiType = ApiType.DELETE,
                Url = $"{_apiUrl}todos/{todoId}"
            });

            return result;
        }

        public async Task<ApiResponse> GetTodoOfUserAsync(string userId, int todoId)
        {
            var result = await _baseService.SendAsync(new ApiRequest()
            {
                ApiType = ApiType.GET,
                Url = $"{_apiUrl}todos/{userId}/{todoId}"
            });

            return result;
        }

        public async Task<ApiResponse> GetTodosOfUserAsync(string userId)
        {
            var result = await _baseService.SendAsync(new ApiRequest()
            {
                ApiType = ApiType.GET,
                Url = $"{_apiUrl}todos/{userId}"
            });

            return result;
        }
    }
}
