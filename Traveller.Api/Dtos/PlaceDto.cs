using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class PlaceDto
{
    public int Id { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; } 
    public string? Country { get; set; }

    public static PlaceDto Map(Place place)
    {
        return new PlaceDto
        {
            Id = place.Id,
            Address = place.Address,
            City = place.City,
            Country = place.Country
        };
    }

    public static Place Map(PlaceDto placeDto)
    {
        if (placeDto.Address != null && placeDto.City != null && placeDto.Country != null)
        {
            return new Place
            {
                Address = placeDto.Address,
                City = placeDto.City,
                Country = placeDto.Country
            };
        }
        else
        {
            throw new ArgumentException("Data is not valid");
        }
    }
}