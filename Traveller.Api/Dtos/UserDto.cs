using System.ComponentModel.DataAnnotations;

namespace Traveller.Api.Dtos;

public record UserDto(string Name, [EmailAddress]string Email, string Password, string Nationality);