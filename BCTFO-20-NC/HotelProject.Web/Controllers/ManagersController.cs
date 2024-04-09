using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace HotelProject.Web.Controllers
{
    public class ManagersController : Controller
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IHotelRepository _hotelRepository;
        public ManagersController(IManagerRepository managerRepository, IHotelRepository hotelRepository)
        {
            _managerRepository = managerRepository;
            _hotelRepository = hotelRepository;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _managerRepository.GetManagers();
            return View(result);
        }

        public async Task<IActionResult> Create()
        {
            var hotels = await _hotelRepository.GetHotelsWithoutManager();
            ViewBag.HotelsWithoutManagers = new SelectList(hotels, "Id", "Name");

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Manager model)
        {
            await _managerRepository.AddManager(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _managerRepository.GetSingleManager(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id)
        {
            await _managerRepository.DeleteManager(id);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Update(int id)
        {
            var result = await _managerRepository.GetSingleManager(id);
            var hotels = await _hotelRepository.GetHotelsWithoutManager();
            ViewBag.HotelsWithoutManagers = new SelectList(hotels, "Id", "Name");

            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePOST(Manager model)
        {
            await _managerRepository.UpdateManager(model);
            return RedirectToAction("Index");
        }

    }
}
