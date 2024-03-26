using HotelProject.Models;
using HotelProject.Repository;

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
        public async void Add_New_Manager_In_Database()
        {
            Manager newManager = new()
            {
                FirstName = "ლევანი",
                LastName = "სვანიძე"
            };

            await _managerRepository.AddManager(newManager);
        }

        [Fact]
        public async void Update_Manager_In_Database()
        {
            Manager manager = new()
            {
                Id = 5,
                FirstName = "ლუკა",
                LastName = "ცაგარეიშვილი"
            };

            await _managerRepository.UpdateManager(manager);
        }

        [Fact]
        public async void Delete_Manager_In_Database()
        {
            await _managerRepository.DeleteManager(5);
        }
    }
}
