using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
