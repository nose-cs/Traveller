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

    public IEnumerable<FlightOffer> Find()
    {
        return _context.FlightOffers.Include(x => x.Image);
    }

    public async ValueTask<FlightOffer?> FindById(int key)
    {
        return await _context.FlightOffers.Include(x => x.Image).FirstOrDefaultAsync(x => x.Id == key);
    }
}