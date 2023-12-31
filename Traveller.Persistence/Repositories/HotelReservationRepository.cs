using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class HotelReservationRepository : IHotelReservationRepository
{
    private readonly TravellerContext _context;
    public HotelReservationRepository(TravellerContext context)
    {
        _context = context;
    }
    public async Task AddAsync(HotelReservation model)
    {
        await _context.AddAsync(model);
    }
    public async Task Remove(int key)
    {
        var hotelReservation = await FindById(key);
        if (hotelReservation is not null)
        {
            _context.Remove(hotelReservation);
        }
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    public IEnumerable<HotelReservation> Find()
    {
        return _context.HotelReservations;
    }
    public IEnumerable<HotelReservation> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<HotelReservation, TInclude>> include)
    {
        return _context.HotelReservations.Include(include);
    }
    public async ValueTask<HotelReservation?> FindById(int key)
    {
        return await _context.HotelReservations.FindAsync(key);
    }
    
    public IEnumerable<HotelReservation> FindWithImages()
    {
        return _context.HotelReservations.Include(x => x.Offer).ThenInclude(x => x.Image);
    }
}