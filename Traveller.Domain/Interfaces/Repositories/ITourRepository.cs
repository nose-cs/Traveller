using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface ITourRepository : IRepository<Tour, int>
{
    Task<IEnumerable<Package>?> FindPackages(int key);
}