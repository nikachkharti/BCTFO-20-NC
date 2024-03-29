using HotelProject.Models;
using HotelProject.Repository;
using Microsoft.Data.SqlClient;

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
        public async void Return_All_Hotels_From_Database()
        {
            var result = await _hotelRepository.GetHotels();
        }

        [Fact]
        public async void Not_Add_New_Hotel_In_Database()
        {
            Hotel newHotel = new()
            {
                Name = "Radisson",
                Rating = 12.0,
                Country = "საქართველო",
                City = "თბილისი",
                PhyisicalAddress = "ვარდების მოედანი"
            };

            await Assert.ThrowsAsync<SqlException>(async () => await _hotelRepository.AddHotel(newHotel));
        }


        [Fact]
        public async void Add_New_Hotel_In_Database()
        {
            Hotel newHotel = new()
            {
                Name = "Radisson",
                Rating = 9.5,
                Country = "საქართველო",
                City = "თბილისი",
                PhyisicalAddress = "ვარდების მოედანი"
            };

            await _hotelRepository.AddHotel(newHotel);
        }

        [Fact]
        public async void Update_Hotel_In_Database()
        {
            Hotel newHotel = new()
            {
                Id = 1,
                Name = "პირველი სასტუმრო",
                Rating = 9.5,
                Country = "საქართველო",
                City = "თბილისი",
                PhyisicalAddress = "ვარდების მოედანი"
            };

            await _hotelRepository.UpdateHotel(newHotel);
        }


        [Fact]
        public async void Delete_Hotel_From_Database()
        {
            await _hotelRepository.DeleteHotel(4);
        }
    }
}
