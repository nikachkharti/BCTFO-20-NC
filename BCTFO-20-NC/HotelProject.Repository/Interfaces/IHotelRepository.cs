using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IHotelRepository : IRepositoryBase<Hotel>, IFullyUpdatable<Hotel>
    {
    }
}
