using Traveller.Domain.Models;

namespace Traveller.Tools;

public partial class Program
{
    private static IEnumerable<FlightOffer> _flightOffers = null!;
    private const int FlightOfferCount = 500;

    private static async Task AddFlightOffersAsync()
    {
        _flightOffers = GenerateFlightOffers();
        foreach (var flightOffer in _flightOffers)
        {
            await _appDbContext.AddAsync(flightOffer);
        }
    }

    private static IEnumerable<FlightOffer> GenerateFlightOffers()
    {
        var date = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        return Enumerable.Range(1, FlightOfferCount).Select(i =>
        {
            var flight = _flights.ElementAt(i % ToursCount);
            var destinationPlace = _places.ElementAt(flight.DestinationId - 1);
            return new FlightOffer
            {
                Title =
                    $"{Verb[Random.Next(0, Verb.Count)]} {Adjectives[Random.Next(0, Adjectives.Count)]} flight to {destinationPlace.City}",
                Description = "",
                Price = Random.Next(100, 1000),
                Capacity = Random.Next(1, 10),
                StartDate = date.AddDays(Random.Next(1, 10)),
                EndDate = date.AddDays(i + Random.Next(10, 1000)),
                AgencyId = i % AgenciesCount + 1,
                ProductId = i % ToursCount + 1
            };
        });
    }
}