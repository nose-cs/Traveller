using Traveller.Domain.Models;

namespace Traveller.Dtos;

public record PackageDetails(IEnumerable<TourDto> Tours, IEnumerable<HotelDto>? Hotels);
public class PackageDto
{
    public record FacilityDto(int? Id, string Name, string Description, double Price);
    public int? Id { get; set; }
    public uint Duration { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public uint Capacity { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? AgencyName { get; set; }
    public int AgencyId { get; set; }
    public int ImageId { get; set; }
    public FileDto? Image { get; set; } = null!;
    public int[] ToursIds { get; set; }
    public int[] FacilitiesIds { get; set; }

    public static PackageDto Map(Package package)
    {
        return new PackageDto
        {
            Id = package.Id, 
            Duration = package.Duration,
            Title = package.Title,
            Description = package.Description,
            Price = package.Price,
            Capacity = package.Capacity,
            StartDate = package.StartDate,
            EndDate = package.EndDate,
            AgencyId = package.AgencyId,
            ImageId = package.ImageId,
        };
    }

    public static Package Map(PackageDto packageDto)
    {
        var package = new Package { 
            Duration = packageDto.Duration,
            Title = packageDto.Title,
            Description = packageDto.Description,
            Price = packageDto.Price,
            Capacity = packageDto.Capacity,
            StartDate = packageDto.StartDate,
            EndDate = packageDto.EndDate,
            ImageId = packageDto.ImageId,
            AgencyId = packageDto.AgencyId };
        
        if (packageDto.Id is null)
        {
            return package;
        }

        package.Id = (int)packageDto.Id;
        return package;
    }
}