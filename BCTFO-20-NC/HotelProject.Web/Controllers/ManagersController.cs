using HotelProject.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class ManagersController : Controller
    {
        private readonly ManagerRepository _managerRepository;
        public ManagersController()
        {
            _managerRepository = new();
        }

        public async Task<IActionResult> Index()
        {
            var result = await _managerRepository.GetManagers();
            return View(result);
        }
    }
}
