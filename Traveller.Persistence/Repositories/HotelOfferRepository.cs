using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class HotelOfferRepository : IRepository<HotelOffer, int>
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
}