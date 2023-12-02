using Traveller.Domain.Models;
using Traveller.Exceptions;

namespace Traveller.Dtos;

public class PlaceDto
{
    public int Id { get; set; }
    public string Address { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Country { get; set; } = null!;

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
        if (placeDto is { Address: not null, City: not null, Country: not null })
        {
            return new Place
            {
                Address = placeDto.Address,
                City = placeDto.City,
                Country = placeDto.Country
            };
        }
        
        throw new BadRequestException("Data is not valid");
    }
}