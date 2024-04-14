using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> GetAll();
        Task<Reservation> GetById(int id);
        Task<Reservation> GetByCheckInCheckOutDate(DateTime checkInDate, DateTime checkoutDate);
        Task Add(Reservation reservation);
        Task Update(Reservation reservation);
        Task Delete(int id);
    }
}
