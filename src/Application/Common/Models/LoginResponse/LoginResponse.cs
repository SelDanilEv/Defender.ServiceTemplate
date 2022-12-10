using Rentel.ServiceTemplate.Application.DTOs;

namespace Rentel.ServiceTemplate.Application.Common.Models.LoginResponse;

public class LoginResponse
{
    public bool Authorized { get; set; } = false;

    public string? Token { get; set; }

    public UserDto? UserDetails { get; set; }

}
