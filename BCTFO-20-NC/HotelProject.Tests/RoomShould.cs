using HotelProject.Models;
using HotelProject.Repository.MicrosoftDataSQLClient;

namespace HotelProject.Tests
{
    public class RoomShould
    {
        private readonly RoomRepository _roomRepository;
        public RoomShould()
        {
            _roomRepository = new();
        }


        [Fact]
        public async void Return_All_Rooms_From_Database()
        {
            var result = await _roomRepository.GetRooms();
        }

        [Fact]
        public async void Return_All_Rooms_Of_Hotel_From_Database()
        {
            var result = await _roomRepository.GetRoomsOfHotel(hotelId: 1);
        }

        [Fact]
        public async void Add_New_Room_In_Database()
        {
            Room newRoom = new()
            {
                Name = "C-40",
                IsFree = true,
                HotelId = 3,
                DailyPrice = 150
            };

            await _roomRepository.AddRoom(newRoom);
        }

        [Fact]
        public async void Update_Room_In_Database()
        {
            Room room = new()
            {
                Id = 28,
                Name = "C-50",
                IsFree = true,
                HotelId = 3,
                DailyPrice = 150
            };

            await _roomRepository.UpdateRoom(room);
        }

        [Fact]
        public async void Delete_Room_In_Database()
        {
            await _roomRepository.DeleteRoom(28);
        }

        [Fact]
        public async void Get_Single_Room()
        {
            var result = await _roomRepository.GetSingleRoom(28);
        }
    }
}
