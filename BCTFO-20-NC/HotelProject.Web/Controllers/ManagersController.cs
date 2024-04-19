using HotelProject.Data;
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
        private readonly ApplicationDbContext _context;
        public ManagersController(IManagerRepository managerRepository, IHotelRepository hotelRepository, ApplicationDbContext context)
        {
            _managerRepository = managerRepository;
            _hotelRepository = hotelRepository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _managerRepository.GetAllAsync(includePropeties: "Hotel");
            return View(result);
        }

        public async Task<IActionResult> Create()
        {
            var hotels = await _hotelRepository.GetAllAsync(x => x.Manager == null);
            ViewBag.HotelsWithoutManagers = new SelectList(hotels, "Id", "Name");

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Manager model)
        {
            await _managerRepository.AddAsync(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _managerRepository.GetAsync(x => x.Id == id, includePropeties: "Hotel");
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id)
        {
            var result = await _managerRepository.GetAsync(x => x.Id == id, includePropeties: "Hotel");

            _managerRepository.Remove(result);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Update(int id)
        {
            var result = await _managerRepository.GetAsync(x => x.Id == id, includePropeties: "Hotel");
            var hotels = await _hotelRepository.GetAllAsync(x => x.Manager == null);
            ViewBag.HotelsWithoutManagers = new SelectList(hotels, "Id", "Name");

            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePOST(Manager model)
        {
            await _managerRepository.Update(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
