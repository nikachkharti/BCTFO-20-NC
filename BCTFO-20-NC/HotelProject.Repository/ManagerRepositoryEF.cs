using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Repository
{
    public class ManagerRepositoryEF : RepositoryBase<Manager>, IManagerRepository
    {
        private readonly ApplicationDbContext _context;
        public ManagerRepositoryEF(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Manager> Update(Manager entity)
        {
            var entityFromDb = await _context.Managers.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (entityFromDb != null)
            {
                entityFromDb.FirstName = entity.FirstName;
                entityFromDb.LastName = entity.LastName;
                entityFromDb.HotelId = entity.HotelId;
            }

            _context.Managers.Update(entityFromDb);
            return entityFromDb;
        }
    }
}
