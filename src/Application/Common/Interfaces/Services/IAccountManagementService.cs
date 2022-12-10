using Rentel.ServiceTemplate.Application.DTOs;
using Rentel.ServiceTemplate.Application.Modules.Auth.Commands;

namespace Rentel.ServiceTemplate.Application.Common.Interfaces;

public interface IAccountManagementService
{
    Task<UserDto> UpdateUserAsync(UpdateAccountInfoCommand command);
}
