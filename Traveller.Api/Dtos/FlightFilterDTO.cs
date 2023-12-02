namespace Traveller.Dtos;

public class FlightFilterDTO
{
    public int? Id { get; set; }
    public string? Source { get; set; } 
    public string? Destination { get; set; } 
    public int? Capacity { get; set; }
    public int? FlightNumber { get; set; }
    public string? Airline { get; set; }
}