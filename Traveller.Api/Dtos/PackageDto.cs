using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class PackageDto
{
    public record FacilityDto(int? Id, string Name, string Description, double Price);

    public int? Id { get; set; }
    public string Name { get; set; } = null!;
    public int Duration { get; set; }
    public IEnumerable<FacilityDto>? Facilities { get; set; }
    public IEnumerable<(int, string)>? Tours { get; set; }

    public static PackageDto Map(Package package)
    {
        return new PackageDto()
        {
            Id = package.Id, Name = package.Name, Duration = package.Duration,
            Facilities = package.Facilities.Select(pf =>
                new FacilityDto(pf.FacilityId, pf.Facility.Name, pf.Facility.Description, pf.Price)),
            Tours = package.Tours.Select(t => (t.Id, $"{t.SourcePlace.City}, {t.SourcePlace.Country} - {t.DestinationPlace.City}, {t.DestinationPlace.Country}"))
        };
    }

    public static Package Map(PackageDto packageDto)
    {
        var package = new Package() { Name = packageDto.Name , Duration = packageDto.Duration };
        if (packageDto.Id is null)
        {
            return package;
        }

        package.Id = (int)packageDto.Id;
        return package;
    }
}