using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class TourReservationRepository : ITourReservationRepository
{
    private readonly TravellerContext _context;
    public TourReservationRepository(TravellerContext context)
    {
        _context = context;
    }
    public async Task AddAsync(TourReservation model)
    {
        await _context.AddAsync(model);
    }
    public async Task Remove(int key)
    {
        var tourReservation = await FindById(key);
        if (tourReservation is not null)
        {
            _context.Remove(tourReservation);
        }
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    public IEnumerable<TourReservation> Find()
    {
        return _context.TourReservations;
    }
    public async ValueTask<TourReservation?> FindById(int key)
    {
        return await _context.TourReservations.FindAsync(key);
    }
}