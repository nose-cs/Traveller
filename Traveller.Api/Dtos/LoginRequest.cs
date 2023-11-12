using System.ComponentModel.DataAnnotations;

namespace Traveller.Api.Dtos;

public record LoginRequest([EmailAddress]string Email, string Password);