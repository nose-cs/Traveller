using Traveller.Domain.Models;

namespace Traveller.Tools;

public partial class Program
{
    private static IEnumerable<Flight> Flights = null!; 
    private const int FlightsCount = 50;
    
    private static async Task AddFlightsAsync()
    {
        Flights = GenerateFlights();
        foreach (var flight in Flights)
        {
            await _appDbContext.AddAsync(flight);
        }
    }
    
    private static readonly List<string> Airlines = new()
    {
        "Cubana de Aviación",
        "Aeroflot",
        "Air France",
        "British Airways",
        "Lufthansa",
        "KLM",
        "Alitalia",
        "Iberia",
        "Aerolíneas Argentinas",
        "Avianca",
        "Aeroméxico",
        "Copa Airlines",
        "TACA",
        "TAM",
        "LAN Airlines",
        "Aer Caribe"
    };

    private static IEnumerable<Flight> GenerateFlights()
    {
        return Enumerable.Range(1, FlightsCount).Select(_ => new Flight
        {
            FlightNumber = Random.Next(100, 1000),
            Airline = Airlines[Random.Next(0, Airlines.Count)],
            SourceId = Random.Next(1, PlacesCount),
            DestinationId = Random.Next(1, PlacesCount)
        });
    }
}