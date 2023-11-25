using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class TourOfferRepository : ITourOfferRepository
{
    private readonly TravellerContext _context;

    public TourOfferRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TourOffer model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var offer = await FindById(key);
        if (offer is not null)
        {
            _context.Remove(offer);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<TourOffer> Find()
    {
        return _context.TourOffers.Include(x => x.Image);
    }

    public async ValueTask<TourOffer?> FindById(int key)
    {
        return await _context.TourOffers.Include(x => x.Image).FirstOrDefaultAsync(x => x.Id == key);
    }
}