using HotelProject.Models;
using HotelProject.Repository.Interfaces;

namespace HotelProject.Repository
{
    public class RoomRepositoryEF : IRoomRepository
    {
        public Task AddRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Room>> GetRooms()
        {
            throw new NotImplementedException();
        }

        public Task<List<Room>> GetRoomsOfHotel(int hotelId)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetSingleRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRoom(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
