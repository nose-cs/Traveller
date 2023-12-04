using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IHotelReservationRepository : IRepository<HotelReservation, int>
{
    public IEnumerable<HotelReservation> FindWithImages();
}