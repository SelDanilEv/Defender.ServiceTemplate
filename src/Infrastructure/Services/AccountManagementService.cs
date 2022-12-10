using AutoMapper;
using Rentel.ServiceTemplate.Application.Common.Exceptions;
using Rentel.ServiceTemplate.Application.Common.Interfaces;
using Rentel.ServiceTemplate.Application.Helpers;
using Rentel.ServiceTemplate.Application.Modules.Auth.Commands;
using Rentel.ServiceTemplate.Infrastructure.Clients.UserManagement;

namespace Rentel.ServiceTemplate.Infrastructure.Services;
public class AccountManagementService : IAccountManagementService
{
    private readonly IUserManagementClient _userManagementClient;
    private readonly ICurrentUserAccessor _currentUserService;
    private readonly IMapper _mapper;

    public AccountManagementService(
        IUserManagementClient userManagementClient,
        ICurrentUserAccessor currentUserService,
        IMapper mapper)
    {
        _userManagementClient = userManagementClient;
        _currentUserService = currentUserService;
        _mapper = mapper;
    }

    public async Task<Application.DTOs.UserDto> UpdateUserAsync(
        UpdateAccountInfoCommand command)
    {
        var requestCommand = new UpdateAccountFromUserCommand
        {
            User = new User
            {
                Id = _currentUserService.User.Id,
                Name = command.Name,
                Email = command.Email,
            }
        };

        try
        {
            var updateResponse = await _userManagementClient.UserPUT2Async(requestCommand);
            return _mapper.Map<Application.DTOs.UserDto>(updateResponse);
        }
        catch (ApiException ex)
        {
            SimpleLogger.Log(ex);

            var message = ExceptionParser.GetValidationMessage(ex);

            throw new ExternalAPIException(message, ex);
        }
    }
}
