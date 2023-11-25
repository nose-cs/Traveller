using Traveller.Domain.Models;
using Traveller.Services;

namespace Traveller.Tools;

public static partial class Program
{
    private static readonly IPasswordService PasswordService = new PasswordService();

    private static async Task AddUsers()
    {
        foreach (var user in Users)
        {
            await _appDbContext.AddAsync(user);
        }
    }

    private static readonly User[] Users =
    {
        new Tourist
        {
            Name = "Tourist", Email = "tourist@gmail", Password = PasswordService.EncryptPassword("1234"),
            Role = Role.Tourist, Country = "Cuba"
        },
        new AgencyUser
        {
            Name = "Marketing", Email = "marketing@gmail", Password = PasswordService.EncryptPassword("1234"),
            Role = Role.MarketingEmployee, AgencyId = 1
        },
        new AgencyUser
        {
            Name = "Agent", Email = "agent@gmail", Password = PasswordService.EncryptPassword("1234"),
            Role = Role.Agent, AgencyId = 1
        },
        new AgencyUser
        {
            Name = "Admin", Email = "agencyAdmin@gmail", Password = PasswordService.EncryptPassword("1234"),
            Role = Role.AgencyAdmin, AgencyId = 1
        },
        new User
        {
            Name = "TravellerAdmin", Email = "admin@gmail", Password = PasswordService.EncryptPassword("1234"),
            Role = Role.TravellerAdmin
        }
    };
}