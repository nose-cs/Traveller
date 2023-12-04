using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class TourDto
{
    public record TourInfo(PlaceDto Place, DayOfWeek Day, TimeOnly Time);
    public int? Id { get; init; }
    public TourInfo SourceInfo { get; init; } = null!;
    public TourInfo DestinationInfo { get; init; } = null!;
    public uint Duration { get; set; }
    public int ImageId { get; set; }
    public FileDto? Image { get; set; }

    public int[]? HotelsIds { get; set; } = null!;

    public static TourDto Map(Tour tour, string imagePath, string imageName)
    {
        var sourcePlaceInfo = PlaceDto.Map(tour.SourcePlace);
        var destinationPlaceInfo = PlaceDto.Map(tour.DestinationPlace);
        var sourceInfo = new TourInfo(sourcePlaceInfo, tour.SourceDay, tour.SourceTime);
        var destinationDay = (DayOfWeek)(((uint)tour.SourceDay + tour.Duration) % 7);
        var destinationInfo = new TourInfo(destinationPlaceInfo, destinationDay, tour.DestinationTime);
        return new TourDto
        {
            Id = tour.Id, SourceInfo = sourceInfo, DestinationInfo = destinationInfo, Duration = tour.Duration, 
            ImageId = tour.ImageId, Image = new FileDto { Id = tour.ImageId, FilePath = imagePath, Name = imageName }
        };
    }

    public static Tour Map(TourDto tourDto)
    {
        var tour = tourDto.Duration == 0 ? new Tour
        {
            SourceDay = tourDto.SourceInfo.Day, SourceTime = tourDto.SourceInfo.Time,
            SourcePlace = PlaceDto.Map(tourDto.SourceInfo.Place),
            DestinationPlace = PlaceDto.Map(tourDto.DestinationInfo.Place),
            DestinationTime = tourDto.DestinationInfo.Time, Duration = tourDto.Duration,
            ImageId = tourDto.ImageId
            
        } : new ExtendedTour
        {   
            SourceDay = tourDto.SourceInfo.Day, SourceTime = tourDto.SourceInfo.Time, 
            SourcePlace = PlaceDto.Map(tourDto.SourceInfo.Place),
            DestinationPlace = PlaceDto.Map(tourDto.DestinationInfo.Place),
            DestinationTime = tourDto.DestinationInfo.Time, Duration = tourDto.Duration,
            ImageId = tourDto.ImageId
        };
        if (tourDto.Id is null)
        {
            return tour;
        }
        tour.Id = (int)tourDto.Id;
        return tour;
    }
}