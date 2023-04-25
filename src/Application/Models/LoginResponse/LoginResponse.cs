using Defender.ServiceTemplate.Application.DTOs;

namespace Defender.ServiceTemplate.Application.Models.LoginResponse;

public class LoginResponse
{
    public bool Authorized { get; set; } = false;

    public string? Token { get; set; }

    public UserDto? UserDetails { get; set; }

}
