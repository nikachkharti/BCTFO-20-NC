using Microsoft.AspNetCore.Mvc;
using Todo.Contracts;

namespace Todo.API.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        //TODO კონტროლერის მხარეს გამოვიძახო სხვა ფუნქციები სერვისებიდან

        [HttpGet]
        public async Task<IActionResult> AllTodos()
        {
            var result = await _todoService.GetAllTodosAsync();
            return Ok(result);
        }

    }
}
