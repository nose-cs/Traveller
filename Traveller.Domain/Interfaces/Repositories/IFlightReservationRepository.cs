using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IFlightReservationRepository : IRepository<FlightReservation, int>
{
    public IEnumerable<FlightReservation> FindWithPhoto();
}