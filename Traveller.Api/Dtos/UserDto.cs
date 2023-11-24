using System.ComponentModel.DataAnnotations;
using Traveller.Domain.Models;

namespace Traveller.Dtos;

public class UserDto
{
    public string Name { get; set; } = null!;
    [EmailAddress] public string Email { get; set; } = null!;
    public string Password { get; set; } = null!; 
    public string Nationality { get; set; } = null!;
    public Role Role { get; set; } = Role.Tourist;

    public static User Map(UserDto userDto, string encryptedPassword, int agencyId)
    {
        return userDto.Role switch
        {
            Role.Tourist => new Tourist
            {
                Name = userDto.Name,
                Email = userDto.Email,
                Password = encryptedPassword,
                Country = userDto.Nationality
            },
            Role.MarketingEmployee => new AgencyUser { Role = userDto.Role, Name = userDto.Name, Email = userDto.Email, Password = encryptedPassword, AgencyId = agencyId },
            Role.Agent => new AgencyUser { Role = userDto.Role, Name = userDto.Name, Email = userDto.Email , Password = encryptedPassword, AgencyId = agencyId },
            Role.AgencyAdmin => new AgencyUser { Role = userDto.Role, Name = userDto.Name, Email = userDto.Email , Password = encryptedPassword, AgencyId = agencyId },
            Role.TravellerAdmin => new User { Role = userDto.Role, Name = userDto.Name, Email = userDto.Email , Password = encryptedPassword },
            _ => throw new ArgumentOutOfRangeException(nameof(userDto.Role), userDto.Role, "Role doesn't exist")
        };
    }
}