using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class HotelsController : Controller
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly ApplicationDbContext _context;
        public HotelsController(IHotelRepository hotelRepository, ApplicationDbContext context)
        {
            _hotelRepository = hotelRepository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _hotelRepository.GetAllAsync();
            return View(result);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Hotel model)
        {
            await _hotelRepository.AddAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var result = await _hotelRepository.GetAsync(x => x.Id == id);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id)
        {
            var result = await _hotelRepository.GetAsync(x => x.Id == id);

            _hotelRepository.Remove(result);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var result = await _hotelRepository.GetAsync(x => x.Id == id);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> UpdatePOST(Hotel model)
        {
            await _hotelRepository.Update(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
