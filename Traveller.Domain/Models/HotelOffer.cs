using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class HotelOffer : IOffer<Hotel, HotelReservation, HotelOffer>
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public uint Capacity { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    
    public int AgencyId { get; set; }
    public virtual Agency Agency { get; set; } = null!;
    
    public int ProductId { get; set; }
    public virtual Hotel Product { get; set; } = null!;

    public virtual ICollection<HotelReservation> Reservations { get; set; } = null!;
}