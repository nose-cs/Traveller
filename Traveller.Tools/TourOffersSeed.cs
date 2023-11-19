using Traveller.Domain.Models;

namespace Traveller.Tools;

public partial class Program
{
    private static IEnumerable<TourOffer> _tourOffers = null!;
    private const int TourOfferCount = 500;

    private static async Task AddTourOffersAsync()
    {
        _tourOffers = GenerateTourOffers();
        foreach (var tourOffer in _tourOffers)
        {
            await _appDbContext.AddAsync(tourOffer);
        }
    }

    private static readonly List<string> Adjectives = new()
    {
        "a wonderful",
        "an amazing",
        "a beautiful",
        "a breathtaking",
        "a stunning",
        "a luxurious",
        "a modern",
    };

    private static IEnumerable<TourOffer> GenerateTourOffers()
    {
        var date = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        return Enumerable.Range(1, TourOfferCount).Select(i =>
        {
            var tour = _tours.ElementAt(i % ToursCount);
            var destinationPlace = _places.ElementAt(tour.DestinationPlaceId - 1);
            return new TourOffer
            {
                Title =
                    $"{Verb[Random.Next(0, Verb.Count)]} {Adjectives[Random.Next(0, Adjectives.Count)]} tour to {destinationPlace.City}, {destinationPlace.Country}",
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