using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Models;

public interface IOffer<TProduct, TReservation, TOffer> : IDbModel
    where TProduct : class, IProduct, new()
    where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
    where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
{
    string Title { get; set; }
    string Description { get; set; }
    double Price { get; set; }
    uint Capacity { get; set; }
    DateTime StartDate { get; set; }
    DateTime? EndDate { get; set; }
    
    int AgencyId { get; set; }
    Agency Agency { get; set; }

    int ProductId { get; set; }
    TProduct Product { get; set; }
    
    ICollection<TReservation> Reservations { get; set; }
}