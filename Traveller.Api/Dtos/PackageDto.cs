using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class PackageDto
{
    public record FacilityDto(int? Id, string Name, string Description, double Price);

    public int? Id { get; set; }
    public string Name { get; set; } = null!;

    public IEnumerable<FacilityDto>? Facilities { get; set; }
    public IEnumerable<int>? Tours { get; set; }

    public static PackageDto Map(Package package)
    {
        return new PackageDto()
        {
            Id = package.Id, Name = package.Name,
            Facilities = package.Facilities.Select(pf =>
                new FacilityDto(pf.FacilityId, pf.Facility.Name, pf.Facility.Description, pf.Price))
        };
    }

    public static Package Map(PackageDto packageDto)
    {
        var package = new Package() { Name = packageDto.Name };
        if (packageDto.Id is null)
        {
            return package;
        }

        package.Id = (int)packageDto.Id;
        return package;
    }
}