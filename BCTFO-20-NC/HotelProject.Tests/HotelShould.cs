using HotelProject.Models;
using HotelProject.Repository;

namespace HotelProject.Tests
{
    public class HotelShould
    {
        private readonly HotelRepository _hotelRepository;
        public HotelShould()
        {
            _hotelRepository = new();
        }

        [Fact]
        public void Return_All_Hotels_From_Database()
        {
            var result = _hotelRepository.GetHotels();
        }

        [Fact]
        public void Add_New_Hotel_In_Database()
        {
            Hotel newHotel = new()
            {
                Name = "Radisson",
                Rating = 9.5,
                Country = "საქართველო",
                City = "თბილისი",
                PhyisicalAddress = "ვარდების მოედანი",
                ManagerId = 1
            };

            _hotelRepository.AddHotel(newHotel);
        }

        [Fact]
        public void Update_Hotel_In_Database()
        {
            Hotel newHotel = new()
            {
                Id = 1,
                Name = "Radisson",
                Rating = 9.5,
                Country = "საქართველო",
                City = "ბათუმი",
                PhyisicalAddress = "ვარდების მოედანი",
                ManagerId = 1
            };

            _hotelRepository.UpdateHotel(newHotel);
        }


        [Fact]
        public void Delete_Hotel_From_Database()
        {
            _hotelRepository.DeleteHotel(1);
        }
    }
}
