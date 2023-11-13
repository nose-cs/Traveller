using System.ComponentModel.DataAnnotations;

namespace Traveller.Dtos;

public record LoginRequestDto([EmailAddress]string Email, string Password);