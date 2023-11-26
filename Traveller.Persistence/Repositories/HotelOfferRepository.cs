using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class HotelOfferRepository : IHotelOfferRepository
{
    private readonly TravellerContext _context;

    public HotelOfferRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(HotelOffer model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var hotelOffer = await FindById(key);
        if (hotelOffer is not null)
        {
            _context.Remove(hotelOffer);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<HotelOffer> Find()
    {
        return _context.HotelOffers;
    }

    public async ValueTask<HotelOffer?> FindById(int key)
    {
        return await _context.HotelOffers.FindAsync(key);
    }

    public IEnumerable<HotelOffer> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<HotelOffer, TInclude>> include)
    {
        return _context.HotelOffers.Include(include);
    }
}