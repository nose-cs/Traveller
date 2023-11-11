namespace Traveller.Domain.Models;

public class Flight : IProduct
{
    public int FlightNumber { get; set; }
    public string Airline { get; set; } = null!;
    public string Source { get; set; } = null!;
    public string Destination { get; set; } = null!;
    public int Id { get; set; }
}