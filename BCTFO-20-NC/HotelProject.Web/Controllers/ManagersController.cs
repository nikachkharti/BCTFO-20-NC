using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class ManagersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
