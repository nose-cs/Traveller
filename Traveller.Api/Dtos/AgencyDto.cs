using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class AgencyDto
{
    public int? Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Fax { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int AddressId { get; set; }
    public PlaceDto Address { get; set; } = null!;

    public static Agency Map(AgencyDto agencyDto)
    {
        var agency = new Agency
        {
            AddressId = agencyDto.AddressId, Address = PlaceDto.Map(agencyDto.Address), 
            Name = agencyDto.Name, Email = agencyDto.Email, Fax = agencyDto.Fax
        };
        if (agencyDto.Id is not null)
        {
            agency.Id = (int)agencyDto.Id;
        }
        return agency;
    }

    public static AgencyDto Map(Agency agency)
    {
        return new AgencyDto
        {
            Id = agency.Id, AddressId = agency.AddressId, Address = PlaceDto.Map(agency.Address), Name = agency.Name,
            Email = agency.Email, Fax = agency.Fax
        };
    }
}