using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class TourDto
{
    public record TourInfo(string Place, Day Day, TimeOnly Time);
    public int? Id { get; init; }
    public TourInfo ArrivalInfo { get; init; } = null!;
    public TourInfo DepartureInfo { get; init; } = null!;
    public ushort Duration { get; set; }

    public static TourDto Map(Tour tour)
    {
        var arrivalInfo = new TourInfo(tour.ArrivalPlace, tour.ArrivalDay, tour.ArrivalTime);
        var departureDay = (Day)((int)(tour.ArrivalDay + tour.Duration) % 7);
        var departureInfo =
            new TourInfo(tour.DeparturePlace, departureDay, tour.DepartureTime);
        return new TourDto()
        {
            Id = tour.Id, ArrivalInfo = arrivalInfo, DepartureInfo = departureInfo, Duration = tour.Duration
        };
    }

    public static Tour Map(TourDto tourDto)
    {
        var tour = tourDto.Duration > 0 ? new Tour()
        {
            ArrivalPlace = tourDto.ArrivalInfo.Place, ArrivalDay = tourDto.ArrivalInfo.Day,
            ArrivalTime = tourDto.ArrivalInfo.Time, DeparturePlace = tourDto.DepartureInfo.Place,
            Duration = tourDto.Duration,
            DepartureTime = tourDto.DepartureInfo.Time
        } : new ExtendedTour()
        {
            ArrivalPlace = tourDto.ArrivalInfo.Place, ArrivalDay = tourDto.ArrivalInfo.Day,
            ArrivalTime = tourDto.ArrivalInfo.Time, DeparturePlace = tourDto.DepartureInfo.Place,
            Duration = tourDto.Duration,
            DepartureTime = tourDto.DepartureInfo.Time
        } ;
        if (tourDto.Id is null)
        {
            return tour;
        }
        tour.Id = (int)tourDto.Id;
        return tour;
    }
}