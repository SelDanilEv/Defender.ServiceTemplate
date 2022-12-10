using Rentel.ServiceTemplate.Application.Common.Models.LoginResponse;

namespace Rentel.ServiceTemplate.Application.Common.Interfaces;

public interface IAuthService
{
    Task<LoginResponse> Authenticate(string token);
}
