using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class OfferFilterDTO
{
    public int? ProductId { get; set; }
    public DateTime? StartDate { get; set; }
    public double? StartPrice { get; set; }
    public double? EndPrice { get; set; }
    public int? AgencyId { get; set; }
    public string? ProductName { get; set; }
    public string? AgencyName { get; set; }
    public ICollection<Facility>? Facilities { get; set; }
}