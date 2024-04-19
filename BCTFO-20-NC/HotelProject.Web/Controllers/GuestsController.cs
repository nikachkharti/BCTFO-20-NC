using AutoMapper;
using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Models.DTOS;
using HotelProject.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class GuestsController : Controller
    {
        private readonly IGuestRepository _guestRepository;
        private readonly IGuestReservationRepository _guestReservationRepository;
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public GuestsController(IGuestRepository guestRepository, IGuestReservationRepository guestReservationRepository, IReservationRepository reservationRepository, IMapper mapper, ApplicationDbContext context)
        {
            _guestRepository = guestRepository;
            _guestReservationRepository = guestReservationRepository;
            _reservationRepository = reservationRepository;
            _mapper = mapper;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<GuestReservation> rawData = await _guestReservationRepository.GetAllAsync(includePropeties: "Guest,Reservation");
            List<GuestReservationDto> result = _mapper.Map<List<GuestReservationDto>>(rawData);

            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(GuestReservationForCreatingDto model)
        {
            Guest newGuest = _mapper.Map<Guest>(model);
            Reservation newReservation = _mapper.Map<Reservation>(model);

            await _guestRepository.AddAsync(newGuest);
            await _reservationRepository.AddAsync(newReservation);

            await _context.SaveChangesAsync();

            var newGuestFromDb = await _guestRepository.GetAsync(x => x.PersonalNumber == model.PersonalNumber);
            var newReservationFromDb = await _reservationRepository.GetAsync(x => x.CheckInDate == model.CheckInDate && x.CheckOutDate == model.CheckOutDate);

            model.GuestId = newGuestFromDb.Id;
            model.ReservationId = newReservationFromDb.Id;

            await _guestReservationRepository.AddAsync(_mapper.Map<GuestReservation>(model));

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var result = await _guestReservationRepository.GetAsync(x => x.Id == id, includePropeties: "Guest,Reservation");
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id, int guestId, int reservationId)
        {
            var guestReservationToRemove = await _guestReservationRepository.GetAsync(filter: x => x.Id == id);
            var guestToRemove = await _guestRepository.GetAsync(filter: x => x.Id == guestId);
            var reservationToRemove = await _reservationRepository.GetAsync(filter: x => x.Id == reservationId);

            _guestReservationRepository.Remove(guestReservationToRemove);
            _guestRepository.Remove(guestToRemove);
            _reservationRepository.Remove(reservationToRemove);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var rawData = await _guestReservationRepository.GetAsync(x => x.Id == id, includePropeties: "Guest,Reservation");
            GuestWithReservationForUpdatingDto result = _mapper.Map<GuestWithReservationForUpdatingDto>(rawData);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePOST(GuestWithReservationForUpdatingDto model)
        {
            await _guestReservationRepository.Update(_mapper.Map<GuestReservation>(model));
            await _guestRepository.Update(_mapper.Map<Guest>(model));
            await _reservationRepository.Update(_mapper.Map<Reservation>(model));

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
