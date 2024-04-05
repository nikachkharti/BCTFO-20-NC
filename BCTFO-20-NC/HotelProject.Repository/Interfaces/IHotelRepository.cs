using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetHotels();
        public Task<Hotel> GetSingleHotel(int id);
        public Task AddHotel(Hotel hotel);
        public Task UpdateHotel(Hotel hotel);
        public Task DeleteHotel(int id);
        public Task<List<Hotel>> GetHotelsWithoutManager();
    }
}
