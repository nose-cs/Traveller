using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface ITourRepository : IRepository<Tour, int>
{
    Task<IEnumerable<Package>?> FindPackages(int key);
    Task<IEnumerable<Hotel>?> FindHotels(int key);
    string GetName(int key);
}