using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class TourDto
{
    public record TourInfo(PlaceDto Place, Day Day, TimeOnly Time);
    public int? Id { get; init; }
    public TourInfo SourceInfo { get; init; } = null!;
    public TourInfo DestinationInfo { get; init; } = null!;
    public uint Duration { get; set; }

    public static TourDto Map(Tour tour)
    {
        var sourcePlaceInfo = PlaceDto.Map(tour.SourcePlace);
        var destinationPlaceInfo = PlaceDto.Map(tour.DestinationPlace);
        var sourceInfo = new TourInfo(sourcePlaceInfo, tour.SourceDay, tour.SourceTime);
        var destinationDay = (Day)(((uint)tour.SourceDay + tour.Duration) % 7);
        var destinationInfo = new TourInfo(destinationPlaceInfo, destinationDay, tour.DestinationTime);
        return new TourDto
        {
            Id = tour.Id, SourceInfo = sourceInfo, DestinationInfo = destinationInfo, Duration = tour.Duration
        };
    }

    public static Tour Map(TourDto tourDto)
    {
        var tour = tourDto.Duration > 0 ? new Tour
        {
            SourceDay = tourDto.SourceInfo.Day, SourceTime = tourDto.SourceInfo.Time,
            SourcePlaceId = tourDto.SourceInfo.Place.Id, DestinationPlaceId = tourDto.DestinationInfo.Place.Id,
            DestinationTime = tourDto.DestinationInfo.Time, Duration = tourDto.Duration,
            
        } : new ExtendedTour
        {   
            SourceDay = tourDto.SourceInfo.Day, SourceTime = tourDto.SourceInfo.Time, 
            DestinationTime = tourDto.DestinationInfo.Time, Duration = tourDto.Duration
        };
        if (tourDto.Id is null)
        {
            return tour;
        }
        tour.Id = (int)tourDto.Id;
        return tour;
    }
}