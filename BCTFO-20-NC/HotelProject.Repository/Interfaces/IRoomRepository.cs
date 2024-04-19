using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IRoomRepository : IRepositoryBase<Room>, IFullyUpdatable<Room>
    {
    }
}
