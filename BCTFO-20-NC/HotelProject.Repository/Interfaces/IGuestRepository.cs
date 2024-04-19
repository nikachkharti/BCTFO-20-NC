using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IGuestRepository : IRepositoryBase<Guest>, IFullyUpdatable<Guest>
    {
    }
}
