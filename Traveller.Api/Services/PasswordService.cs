using System.Security.Cryptography;
using Traveller.Domain.Models;
using Traveller.Exceptions;

namespace Traveller.Services;

public class PasswordService : IPasswordService
{
    private const string Salt = "randomSalt";
    public string EncryptPassword(string password)
    {
        var passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
        var saltBytes = System.Text.Encoding.UTF8.GetBytes(Salt);

        byte[] hashedBytes;
        using (var hmac = new HMACSHA256(saltBytes))
        {
            hashedBytes = hmac.ComputeHash(passwordBytes);
        }

        var encryptedPassword = Convert.ToBase64String(hashedBytes);
        return encryptedPassword;
    }

    public bool CheckPassword(string password, User user)
    {
        return EncryptPassword(password) == user.Password;
    }
}