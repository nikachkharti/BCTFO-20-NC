using HotelProject.Models;
using HotelProject.Repository;
using HotelProject.Repository.Exceptions;

namespace HotelProject.Tests
{
    public class ManagerShould
    {
        private readonly ManagerRepository _managerRepository;
        public ManagerShould()
        {
            _managerRepository = new();
        }

        [Fact]
        public async void Return_All_Managers_From_Database()
        {
            var result = await _managerRepository.GetManagers();
        }


        [Fact]
        public async void Not_Add_New_Manager_In_Database()
        {
            Manager newManager = new()
            {
                FirstName = "ლევანი",
                LastName = "სვანიძე",
                HotelId = 55,
            };

            await Assert.ThrowsAsync<HotelNotFoundException>(async () => await _managerRepository.AddManager(newManager));
        }

        [Fact]
        public async void Add_New_Manager_In_Database()
        {
            Manager newManager = new()
            {
                FirstName = "ლევანი",
                LastName = "სვანიძე",
                HotelId = 5,
            };

            await _managerRepository.AddManager(newManager);
        }

        [Fact]
        public async void Update_Manager_In_Database()
        {
            Manager manager = new()
            {
                Id = 4,
                FirstName = "ლუკა",
                LastName = "ცაგარეიშვილი",
                HotelId = 5,
            };

            await _managerRepository.UpdateManager(manager);
        }

        [Fact]
        public async void Delete_Manager_In_Database()
        {
            await _managerRepository.DeleteManager(4);
        }

        [Fact]
        public async void GetSingleManager()
        {
            var result = await _managerRepository.GetSingleManager(1);
        }
    }
}
