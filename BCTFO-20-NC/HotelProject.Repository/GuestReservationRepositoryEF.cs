using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Repository
{
    public class GuestReservationRepositoryEF : IGuestReservationRepository
    {
        private readonly ApplicationDbContext _context;
        public GuestReservationRepositoryEF(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(GuestReservation guestReservation)
        {
            if (guestReservation == null)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            await _context.GuestReservations.AddAsync(guestReservation);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            var entity = await _context.GuestReservations
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            _context.GuestReservations.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<GuestReservation>> GetAll()
        {
            var entities = await _context.GuestReservations
                .Include(nameof(Reservation))
                .Include(nameof(Guest))
                .ToListAsync();

            if (entities == null)
            {
                throw new NullReferenceException("Entities not found");
            }

            return entities;
        }

        public async Task<GuestReservation> GetById(int id)
        {
            var entity = await _context.GuestReservations
                .Include(nameof(Reservation))
                .Include(nameof(Guest))
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            return entity;
        }

        public async Task Update(GuestReservation guestReservation)
        {
            if (guestReservation == null || guestReservation.Id <= 0)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            var entity = await _context.GuestReservations.FirstOrDefaultAsync(x => x.Id == guestReservation.Id);

            if (entity == null)
            {
                throw new NullReferenceException("Entity not found");
            }

            entity.GuestId = guestReservation.GuestId;
            entity.ReservationId = guestReservation.ReservationId;

            _context.GuestReservations.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
