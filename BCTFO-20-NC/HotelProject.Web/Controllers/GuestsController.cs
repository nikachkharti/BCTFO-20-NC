using AutoMapper;
using HotelProject.Models;
using HotelProject.Models.DataTransferObjects;
using HotelProject.Repository.Interfaces;
using HotelProject.Repository.MicrosoftDataSQLClient;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class GuestsController : Controller
    {
        private readonly IGuestRepository _guestRepository;
        private readonly IGuestReservationRepository _guestReservationRepository;
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public GuestsController(IGuestRepository guestRepository, IGuestReservationRepository guestReservationRepository, IReservationRepository reservationRepository, IMapper mapper)
        {
            _guestRepository = guestRepository;
            _guestReservationRepository = guestReservationRepository;
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<GuestReservation> rawData = await _guestReservationRepository.GetAll();
            List<GuestWithReservationDto> result = _mapper.Map<List<GuestWithReservationDto>>(rawData);

            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(GuestWithReservationForCreatingDto model)
        {
            Guest newGuest = _mapper.Map<Guest>(model);
            Reservation newReservation = _mapper.Map<Reservation>(model);

            await _guestRepository.Add(newGuest);
            await _reservationRepository.Add(newReservation);

            var newGuestFromDb = await _guestRepository.GetByPin(model.PersonalNumber);
            var newReservationFromDb = await _reservationRepository.GetByCheckInCheckOutDate(model.CheckInDate, model.CheckOutDate);

            model.GuestId = newGuestFromDb.Id;
            model.ReservationId = newReservationFromDb.Id;

            await _guestReservationRepository.Add(_mapper.Map<GuestReservation>(model));

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _guestReservationRepository.GetById(id);
            return View(result);
        }


        [HttpPost]
        public async Task<IActionResult> DeletePOST(int id, int guestId, int reservationId)
        {
            await _guestReservationRepository.Delete(id);
            await _guestRepository.Delete(guestId);
            await _reservationRepository.Delete(reservationId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var rawData = await _guestReservationRepository.GetById(id);
            GuestWithReservationForUpdatingDto result = _mapper.Map<GuestWithReservationForUpdatingDto>(rawData);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePOST(GuestWithReservationForUpdatingDto model)
        {
            await _guestReservationRepository.Update(_mapper.Map<GuestReservation>(model));
            await _guestRepository.Update(_mapper.Map<Guest>(model));
            await _reservationRepository.Update(_mapper.Map<Reservation>(model));
            return RedirectToAction("Index");
        }
    }
}
