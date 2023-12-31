using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class TourFilterDTO : PaginationDto
{
    public int? Id { get; set; } 
    public string? Destination { get; set; }
    public string? Source { get; set; }
    public int? Duration { get; set; }
    public DayOfWeek? StartDay { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
}