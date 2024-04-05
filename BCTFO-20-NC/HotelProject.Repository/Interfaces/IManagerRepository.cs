using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IManagerRepository
    {
        public Task<List<Manager>> GetManagers();
        public Task<Manager> GetSingleManager(int id);
        public Task AddManager(Manager manager);
        public Task UpdateManager(Manager manager);
        public Task DeleteManager(int id);
    }
}
