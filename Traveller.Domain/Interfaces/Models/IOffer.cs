using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Models;

public interface IOffer<TReservation, TOffer> : IDbModel
    where TReservation : class, IReservation<TReservation, TOffer>, new()
    where TOffer : class, IOffer<TReservation, TOffer>, new()
{
    string Title { get; set; }
    string Description { get; set; }
    double Price { get; set; }
    uint Capacity { get; set; }
    DateTime StartDate { get; set; }
    DateTime? EndDate { get; set; }
    
    int AgencyId { get; set; }
    Agency Agency { get; set; }

    int ImageId { get; set; }
    Image Image { get; set; }
    
    ICollection<TReservation> Reservations { get; set; }
}

public interface IOffer<TProduct, TReservation, TOffer> : IOffer<TReservation, TOffer>
    where TProduct : class, IProduct, new()
    where TReservation : class, IReservation<TProduct, TReservation, TOffer>, new()
    where TOffer : class, IOffer<TProduct, TReservation, TOffer>, new()
{
    int ProductId { get; set; }
    TProduct Product { get; set; }
}