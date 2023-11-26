using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class FlightOfferRepository : IFlightOfferRepository
{
    private readonly TravellerContext _context;

    public FlightOfferRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(FlightOffer model)
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

    public IEnumerable<FlightOffer> Find()
    {
        return _context.FlightOffers;
    }

    public async ValueTask<FlightOffer?> FindById(int key)
    {
        return await _context.FlightOffers.FindAsync(key);
    }

    public IEnumerable<FlightOffer> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<FlightOffer, TInclude>> include)
    {
        return _context.FlightOffers.Include(include);
    }
}