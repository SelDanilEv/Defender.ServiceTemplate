using AutoMapper;
using Rentel.ServiceTemplate.Application.Common.Interfaces;
using Rentel.ServiceTemplate.Infrastructure.Clients.UserManagement;

namespace Rentel.ServiceTemplate.Infrastructure.Services;
public class AuthService : IAuthService
{
    private readonly IUserManagementClient _userManagementClient;
    private readonly IMapper _mapper;

    public AuthService(
        IUserManagementClient userManagementClient,
        IMapper mapper)
    {
        _userManagementClient = userManagementClient;
        _mapper = mapper;
    }

    public async Task<Application.Common.Models.LoginResponse.LoginResponse> Authenticate(string token)
    {
        var command = new LoginGoogleCommand { Token = token };

        var loginResponse = await _userManagementClient.GoogleAsync(command);

        return _mapper.Map<Application.Common.Models.LoginResponse.LoginResponse>(loginResponse);
    }
}
