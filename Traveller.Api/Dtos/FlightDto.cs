using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class FlightDto
{
    public int? Id { get; set; }
    public int FlightNumber { get; set; }
    public string Airline { get; set; } = null!;
    public PlaceDto Source { get; set; } = null!;
    public PlaceDto Destination { get; set; } = null!;

    public static Flight Map(FlightDto flightDto)
    {
        var flight = new Flight()
        {
            FlightNumber = flightDto.FlightNumber, Airline = flightDto.Airline, SourceId = flightDto.Source.Id,
            DestinationId = flightDto.Destination.Id
        };
        if (flightDto.Id is null)
        {
            return flight;
        }

        flight.Id = (int)flightDto.Id;
        return flight;
    }

    public static FlightDto Map(Flight flight)
    {
        return new FlightDto()
        {
            Id = flight.Id, FlightNumber = flight.FlightNumber, Airline = flight.Airline, 
            Source = PlaceDto.Map(flight.Source), Destination = PlaceDto.Map(flight.Destination)
        };
    }
}