using Defender.ServiceTemplate.Application.Models.LoginResponse;

namespace Defender.ServiceTemplate.Application.Common.Interfaces;

public interface IAuthService
{
    Task<LoginResponse> Authenticate(string token);
}
