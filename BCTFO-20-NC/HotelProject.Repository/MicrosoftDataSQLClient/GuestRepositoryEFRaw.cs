using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


//CREATE PROCEDURE sp_Insert_New_Guest
//@firstName NVARCHAR(50),
//@lastName NVARCHAR(50),
//@personalNumber NVARCHAR(50),
//@phoneNumber NVARCHAR(50)
//AS
//BEGIN
//	INSERT INTO Guests (FirstName, LastName, PersonalNumber, PhoneNumber)
//	VALUES(@firstName, @lastName, @personalNumber, @phoneNumber)
//END


//CREATE PROCEDURE sp_Get_Guest_By_PersonalNumber
//@personalNumber NVARCHAR(11)
//AS
//BEGIN
//	SELECT*FROM Guests
//	WHERE PersonalNumber = @personalNumber
//END



namespace HotelProject.Repository.MicrosoftDataSQLClient
{
    public class GuestRepositoryEFRaw : IGuestRepository
    {
        private readonly ApplicationDbContext _context;
        public GuestRepositoryEFRaw(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Guest guest)
        {
            await _context.Database.ExecuteSqlRawAsync("sp_Insert_New_Guest",
                new SqlParameter("firstName", guest.FirstName),
                new SqlParameter("lastName", guest.LastName),
                new SqlParameter("personalNumber", guest.PersonalNumber),
                new SqlParameter("phoneNumber", guest.PhoneNumber)
                );
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Guest>> GetAll()
        {
            var guests = await _context.Guests
                .FromSqlRaw("SELECT*FROM Guests")
                .ToListAsync();
            return guests;
        }

        public async Task<Guest> GetById(int id)
        {
            var guest = await _context.Guests
                .FromSqlRaw("SELECT*FROM Guests WHERE Id = @id", new SqlParameter("id", id))
                .FirstOrDefaultAsync();
            return guest;
        }

        public async Task<Guest> GetByPin(string personalNumber)
        {
            var guest = await _context.Guests
                .FromSqlRaw($"EXECUTE sp_Get_Guest_By_PersonalNumber", new SqlParameter("personalNumber", personalNumber))
                .FirstOrDefaultAsync();
            return guest;
        }

        public Task Update(Guest guest)
        {
            throw new NotImplementedException();
        }
    }
}
