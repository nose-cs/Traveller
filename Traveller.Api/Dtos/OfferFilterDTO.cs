using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class OfferFilterDTO
{
    public string? Title { get; set; }
    public int? ProductId { get; set; }
    public DateTime? StartDate { get; set; }
    public double? StartPrice { get; set; }
    public double? EndPrice { get; set; }
    public int? AgencyId { get; set; }
    public int? Capacity { get; set; }
    public string? ProductName { get; set; }
    public string? AgencyName { get; set; }
    public int? PageIndex { get; set; }
    public int? PageSize { get; set; }
    public string? OrderBy { get; set; }
    public bool? Descending { get; set; }
}