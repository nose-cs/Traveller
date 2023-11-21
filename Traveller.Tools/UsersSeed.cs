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
            Name = "Admin", Email = "admin@gmail", Password = PasswordService.EncryptPassword("1234"),
            Role = Role.Admin, AgencyId = 1
        }
    };
}