using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Repository
{
    public class GuestReservationRepositoryEF : RepositoryBase<GuestReservation>, IGuestReservationRepository
    {
        private readonly ApplicationDbContext _context;
        public GuestReservationRepositoryEF(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<GuestReservation> Update(GuestReservation entity)
        {
            var entityFromDb = await _context.GuestReservations.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (entityFromDb != null)
            {
                entityFromDb.GuestId = entity.GuestId;
                entityFromDb.ReservationId = entity.ReservationId;
            }

            _context.GuestReservations.Update(entityFromDb);
            return entityFromDb;
        }
    }
}
