using Traveller.Domain.Models;

namespace Traveller.Tools;

public partial class Program
{
    private static IEnumerable<Tour> _tours = null!;
    private const int ToursCount = 50;

    private static async Task AddToursAsync()
    {
        _tours = GenerateTours();
        foreach (var tour in _tours)
        {
            await _appDbContext.AddAsync(tour);
        }
    }

    private static IEnumerable<Tour> GenerateTours()
    {
        return Enumerable.Range(1, ToursCount).Select(_ =>
        {
            var startDay = (Day)Random.Next(0, 6);
            var duration = (ushort)Random.Next(0, 5);

            if (duration == 0)
                return new Tour
                {
                    SourceDay = startDay,
                    Duration = duration,
                    SourceTime = TimeOnly.FromDateTime(DateTime.Now),
                    SourcePlaceId = Random.Next(1, PlacesCount),
                    DestinationTime = TimeOnly.FromDateTime(DateTime.UtcNow),
                    DestinationPlaceId = Random.Next(1, PlacesCount)
                };

            var take = Random.Next(1, 10);
            var skip = Random.Next(0, HotelCount - take);
            return new ExtendedTour
            {
                SourceDay = startDay,
                Duration = duration,
                SourceTime = TimeOnly.FromDateTime(DateTime.Now),
                SourcePlaceId = Random.Next(1, PlacesCount),
                DestinationTime = TimeOnly.FromDateTime(DateTime.UtcNow),
                DestinationPlaceId = Random.Next(1, PlacesCount),
                Hotels = _hotels.Skip(skip).Take(take).ToList()
            };
        });
    }
}