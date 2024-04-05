using HotelProject.Models;
using HotelProject.Repository.Interfaces;

namespace HotelProject.Repository
{
    public class HotelRepositoryEF : IHotelRepository
    {
        public Task AddHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHotel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Hotel>> GetHotels()
        {
            throw new NotImplementedException();
        }

        public Task<List<Hotel>> GetHotelsWithoutManager()
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> GetSingleHotel(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
