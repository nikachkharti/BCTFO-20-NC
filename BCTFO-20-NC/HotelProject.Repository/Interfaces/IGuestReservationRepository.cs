using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IGuestReservationRepository : IRepositoryBase<GuestReservation>, IFullyUpdatable<GuestReservation>
    {
    }
}
