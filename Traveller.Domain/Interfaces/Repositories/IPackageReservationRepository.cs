using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IPackageReservationRepository : IRepository<PackageReservation, int>
{
    public IEnumerable<PackageReservation> FindWithPackagePhoto();
}