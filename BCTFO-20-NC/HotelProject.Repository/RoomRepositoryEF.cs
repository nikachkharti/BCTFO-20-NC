using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Repository
{
    public class RoomRepositoryEF : RepositoryBase<Room>, IRoomRepository
    {
        private readonly ApplicationDbContext _context;
        public RoomRepositoryEF(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Room> Update(Room entity)
        {
            var entityFromDb = await _context.Rooms.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (entityFromDb != null)
            {
                entityFromDb.Name = entity.Name;
                entityFromDb.IsFree = entity.IsFree;
                entityFromDb.DailyPrice = entity.DailyPrice;
                entityFromDb.HotelId = entity.HotelId;
            }

            _context.Rooms.Update(entityFromDb);
            return entityFromDb;
        }
    }
}
