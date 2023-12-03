using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IPackageRepository : IRepository<Package, int>
{
    IEnumerable<Tour> FindTours(int key);
    IEnumerable<PackageFacility> FindPackageFacilities(int key);

    Task AddWithToursAsync(Package model, params int[] toursId);

    public bool RemovePackageFacility(int packageId, int facilityId);
    public bool RemoveAllPackageFacility(int packageId);
}