using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IReservationRepository : IRepositoryBase<Reservation>, IFullyUpdatable<Reservation>
    {
    }
}
