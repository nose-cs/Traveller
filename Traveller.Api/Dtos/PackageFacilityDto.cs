using Traveller.Domain.Models;

namespace Traveller.Dtos
{
    public record FacilityDto(int Id, string Name, string Description);
    public record FacilityFilterDto(int? Id, string? Name, string? Description, int? PageIndex, int? PageSize, string? OrderBy, bool? Descending);
    public class PackageFacilityDto
    {
        public double Price { get; set; }
        public int PackageId { get; set; }
        public FacilityDto Facility { get; set; }

        public static PackageFacilityDto Map(PackageFacility packageFacility)
        {
            return new PackageFacilityDto() { 
                Price = packageFacility.Price, 
                PackageId = packageFacility.PackageId, 
                Facility = new FacilityDto(packageFacility.Facility.Id, packageFacility.Facility.Name, packageFacility.Facility.Description)
            };
        }
    }
}

