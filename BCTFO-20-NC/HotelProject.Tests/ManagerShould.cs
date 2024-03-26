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
        public void Return_All_Managers_From_Database()
        {
            var result = _managerRepository.GetManagers();
        }


        [Fact]
        public void Add_New_Manager_In_Database()
        {
            Manager newManager = new()
            {
                FirstName = "ლუკა",
                LastName = "ცაგარეიშვილი"
            };

            _managerRepository.AddManager(newManager);
        }

        [Fact]
        public void Update_Manager_In_Database()
        {
            Manager newManager = new()
            {
                Id = 4,
                FirstName = "თორნიკე",
                LastName = "ცაგარეიშვილი"
            };

            _managerRepository.UpdateManager(newManager);
        }

        [Fact]
        public void Delete_Manager_In_Database()
        {
            _managerRepository.DeleteManager(4);
        }
    }
}
