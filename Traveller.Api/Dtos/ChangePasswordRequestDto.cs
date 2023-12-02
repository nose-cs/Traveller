using System.ComponentModel.DataAnnotations;

namespace Traveller.Dtos;

public record ChangePasswordRequestDto(string OldPassword, string NewPassword);