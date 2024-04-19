using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Repository
{
    public class HotelRepositoryEF : RepositoryBase<Hotel>, IHotelRepository
    {
        private readonly ApplicationDbContext _context;
        public HotelRepositoryEF(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Hotel> Update(Hotel entity)
        {
            var entityFromDb = await _context.Hotels.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (entityFromDb != null)
            {
                entityFromDb.Name = entity.Name;
                entityFromDb.Rating = entity.Rating;
                entityFromDb.Country = entity.Country;
                entityFromDb.City = entity.City;
                entityFromDb.PhyisicalAddress = entity.PhyisicalAddress;
            }

            _context.Hotels.Update(entityFromDb);
            return entityFromDb;
        }
    }
}
