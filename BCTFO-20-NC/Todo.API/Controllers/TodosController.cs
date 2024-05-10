using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Todo.Contracts;

namespace Todo.API.Controllers
{
    [Route("api/todos")]
    [ApiController]
    [Authorize]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        //TODO შექმენით endpoint რომელიც წამოიღებს კონკრეტული user-ის ყველა საქმეს
        //TODO შექმენით endpoint რომელიც წამოიღებს კონკრეტული user-ის ერთ კონკრეტულ საქმეს
        //TODO შექმენით endpoint რომელიც ბაზაში დაამატებს ახალ საქმეს რომელიმე კონკრეტული user - ისთვის (გაითვალისწინეთ რომ დაადოთ შემდეგი ვალიდაცია: user  - მა საქმის წაშლა უნდა მოახერხოს მხოლოდ საკუთარი თავისთვის თუ ის არ არის ადმინი)
        //TODO შექმენით endpoint რომელიც ბაზიდან წაშლის უკვე არსებულ საქმეს რომელიც გაწერილია რომელიმე user - ზე (გაითვალისწინეთ რომ დაადოთ შემდეგი ვალიდაცია: user  - მა საქმის წაშლა უნდა მოახერხოს მხოლოდ საკუთარი თავისთვის თუ ის არ არის ადმინი)


        [HttpGet]
        public async Task<IActionResult> AllTodos()
        {
            var result = await _todoService.GetAllTodosAsync();
            return Ok(result);
        }

    }
}
