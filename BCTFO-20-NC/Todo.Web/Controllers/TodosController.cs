using Microsoft.AspNetCore.Mvc;
using Todo.Web.Interfaces;

namespace Todo.Web.Controllers
{
    public class TodosController : Controller
    {
        private readonly ITodoService _todoService;
        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _todoService.GetTodosOfUserAsync("87746F88-DC38-4756-924A-B95CFF3A1D8A");
            return View();
        }
    }
}
