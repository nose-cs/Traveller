using Microsoft.EntityFrameworkCore;
using Traveller.Domain.Interfaces.Repositories;
using Traveller.Domain.Models;

namespace Traveller.Persistence.Repositories;

public class TourRepository : ITourRepository
{
    private readonly TravellerContext _context;

    public TourRepository(TravellerContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Tour model)
    {
        await _context.AddAsync(model);
    }

    public async Task Remove(int key)
    {
        var tour = await FindById(key);
        if (tour is not null)
        {
            _context.Remove(tour);
        }
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Tour> Find()
    {
        return _context.Tours.Include(t=> t.DestinationPlace).Include(t=> t.SourcePlace).Include(t => t.Image).AsNoTracking();
    }

    public async ValueTask<Tour?> FindById(int key)
    {
        return await _context.Tours.Include(t => t.DestinationPlace).Include(t => t.SourcePlace)
            .Include(t => t.Image).FirstOrDefaultAsync(t => t.Id == key);
    }

    public IEnumerable<Package> FindPackages(int key)
    {
        var packages = _context.Packages.Where(x => x.Tours.Any(packageTour => packageTour.TourId == key));
        return packages;
    }

    public async Task<IEnumerable<Hotel>?> FindHotels(int key)
    {
        var tour = await _context.ExtendedTours
            .Include(t => t.Hotels)
            .ThenInclude(x => x.Image)
            .Include(x => x.Hotels)
            .ThenInclude(x => x.Address)
            .FirstOrDefaultAsync(t => t.Id == key);
        return tour?.Hotels;
    } 

    public string GetName(int key)
    {
        return _context.Tours.AsNoTracking()
            .Include(t => t.DestinationPlace)
            .Include(t => t.SourcePlace)
            .Where(tour => tour.Id == key)
            .Select(tour =>
                $"{tour.SourcePlace.City}, {tour.SourcePlace.Country} - {tour.DestinationPlace.City}, {tour.DestinationPlace.Country}")
            .First();
    }

    public async Task AddWithHotelsAsync(ExtendedTour tour, HashSet<int> hotelsIds)
    {
        var hotels = _context.Hotels.Where(x => hotelsIds.Contains(x.Id));
        tour.Hotels = new List<Hotel>(hotels);
        await _context.AddAsync(tour);
    }

    public IEnumerable<Tour> FindTourByIds(HashSet<int> ids)
    {
        return _context.Tours.Where(x => ids.Contains(x.Id));
    }

    public IEnumerable<Tour> FindWithInclude<TInclude>(System.Linq.Expressions.Expression<Func<Tour, TInclude>> include)
    {
        return _context.Tours.Include(include);
    }
}