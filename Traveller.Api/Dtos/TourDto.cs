using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class TourDto
{
    public record TourInfo(string Place, Day Day, TimeOnly Time);

    public int? Id { get; init; }
    public TourInfo ArrivalInfo { get; init; } = null!;
    public TourInfo DepartureInfo { get; init; } = null!;
    public IEnumerable<int>? PackagesId { get; set; }

    public static TourDto Map(Tour tour)
    {
        var arrivalInfo = new TourInfo(tour.ArrivalPlace, tour.ArrivalDay, tour.ArrivalTime);
        var departureInfo = new TourInfo(tour.DeparturePlace, tour.DepartureDay, tour.DepartureTime);
        return new TourDto()
        {
            Id = tour.Id, ArrivalInfo = arrivalInfo, DepartureInfo = departureInfo,
            PackagesId = tour.Packages.Select(p => p.Id)
        };
    }

    public static Tour Map(TourDto tourDto)
    {
        var tour = new Tour()
        {
            ArrivalPlace = tourDto.ArrivalInfo.Place, ArrivalDay = tourDto.ArrivalInfo.Day,
            ArrivalTime = tourDto.ArrivalInfo.Time, DeparturePlace = tourDto.DepartureInfo.Place,
            DepartureDay = tourDto.DepartureInfo.Day, DepartureTime = tourDto.DepartureInfo.Time
        };
        if (tourDto.Id is null)
        {
            return tour;
        }

        tour.Id = (int)tourDto.Id;
        return tour;
    }
}