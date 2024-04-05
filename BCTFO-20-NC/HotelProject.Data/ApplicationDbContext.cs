using HotelProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }

        public static string ConnectionString { get; } = "Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=DOITHotel_BCTFO;Trusted_Connection=True;TrustServerCertificate=True";
    }
}
