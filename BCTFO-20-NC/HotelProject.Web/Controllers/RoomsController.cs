using HotelProject.Repository;
using HotelProject.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IRoomRepository _roomRepository;
        public RoomsController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _roomRepository.GetRooms();
            return View(result);
        }
    }
}
