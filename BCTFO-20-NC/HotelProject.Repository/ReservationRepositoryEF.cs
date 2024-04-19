using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Repository
{
    public class ReservationRepositoryEF : RepositoryBase<Reservation>, IReservationRepository
    {
        private readonly ApplicationDbContext _context;
        public ReservationRepositoryEF(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Reservation> Update(Reservation entity)
        {
            var entityFromDb = await _context.Reservations.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (entityFromDb != null)
            {
                entityFromDb.CheckInDate = entity.CheckInDate;
                entityFromDb.CheckOutDate = entity.CheckOutDate;
            }

            _context.Reservations.Update(entityFromDb);
            return entityFromDb;
        }
    }
}
