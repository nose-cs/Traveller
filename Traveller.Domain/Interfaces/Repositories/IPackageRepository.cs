using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IPackageRepository : IRepository<Package, int>
{
    IEnumerable<Tour> FindTours(int key);
    
    IEnumerable<PackageFacility> FindFacilities(int key);
    Task<IEnumerable<Hotel>> FindHotels(int key);

    Task AddWithToursAsync(Package model, params int[] toursId);
}