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
        var Offer = await FindById(key);
        if (Offer is not null)
        {
            _context.Remove(Offer);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<TourOffer> Find()
    {
        return _context.TourOffers;
    }

    public async ValueTask<TourOffer?> FindById(int key)
    {
        return await _context.TourOffers.FindAsync(key);
    }

    public IEnumerable<TourOffer> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<TourOffer, TInclude>> include)
    {
        return _context.TourOffers.Include(include);
    }
}