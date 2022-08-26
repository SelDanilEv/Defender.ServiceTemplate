using Defender.ServiceTemplate.Application.DTOs;
using Defender.ServiceTemplate.Application.Modules.Auth.Commands;

namespace Defender.ServiceTemplate.Application.Common.Interfaces;

public interface IAccountManagementService
{
    Task<UserDto> UpdateUserAsync(UpdateAccountInfoCommand command);
}
