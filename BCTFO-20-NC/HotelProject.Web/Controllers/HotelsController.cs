using HotelProject.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class HotelsController : Controller
    {
        private readonly HotelRepository _hotelRepository;
        public HotelsController()
        {
            _hotelRepository = new HotelRepository();
        }

        public async Task<IActionResult> Index()
        {
            var result = await _hotelRepository.GetHotels();
            return View(result);
        }
    }
}
