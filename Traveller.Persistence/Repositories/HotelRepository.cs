using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class HotelRepository : IHotelRepository
{
    private readonly TravellerContext _context;

    public HotelRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Hotel model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var hotel = await FindById(key);
        if (hotel is not null)
        {
            _context.Remove(hotel);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Hotel> Find()
    {
        return _context.Hotels.Include(h => h.Address).Include(h => h.Image);
    }

    public async ValueTask<Hotel?> FindById(int key)
    {
        return await _context.Hotels.Include(h => h.Address).Include(h => h.Image).FirstOrDefaultAsync(h => h.Id == key);
    }

    public string GetName(int key)
    {
        return _context.Hotels.Where(hotel => hotel.Id == key).Select(hotel => hotel.Name).First();
    }

    public Task<IEnumerable<HotelOffer>> GetOffers(int key)
    {
        return Task.FromResult<IEnumerable<HotelOffer>>(_context.HotelOffers.Include(ho => ho.Agency).Where(ho => ho.ProductId == key));
    }

    public IEnumerable<Hotel> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<Hotel, TInclude>> include)
    {
        return _context.Hotels.Include(include);
    }
}