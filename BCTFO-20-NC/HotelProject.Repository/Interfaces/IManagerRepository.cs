using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IManagerRepository : IRepositoryBase<Manager>, IFullyUpdatable<Manager>
    {
    }
}
