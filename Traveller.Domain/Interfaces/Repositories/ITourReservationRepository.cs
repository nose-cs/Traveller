using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface ITourReservationRepository : IRepository<TourReservation, int>
{
    public IEnumerable<TourReservation> FindWithPhoto();
}