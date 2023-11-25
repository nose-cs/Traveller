using Traveller.Domain.Interfaces.Models;

namespace Traveller.Domain.Models;

public class Flight : IProduct
{
    public int FlightNumber { get; set; }
    public string Airline { get; set; } = null!;
    public int SourceId { get; set; }
    public Place Source { get; set; } = null!;
    public int DestinationId { get; set; }
    public Place Destination { get; set; } = null!;
    public int Id { get; set; }
    
    public int ImageId { get; set; }
    public Image Image { get; set; } = null!;
}