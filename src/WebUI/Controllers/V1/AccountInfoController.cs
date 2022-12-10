using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Rentel.ServiceTemplate.Application.Modules.Auth.Commands;
using Rentel.ServiceTemplate.Application.DTOs;
using Rentel.ServiceTemplate.Domain.Models;
using Rentel.ServiceTemplate.WebUI.Attributes;

namespace Rentel.ServiceTemplate.WebUI.Controllers.V1;

public class AccountInfoController : BaseApiController
{
    public AccountInfoController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
    {
    }

    [HttpPut("update")]
    [Auth(Roles.Any)]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<UserDto> UpdateAccountInfoAsync(
        [FromBody] UpdateAccountInfoCommand command)
    {
        return await ProcessApiCallWithoutMappingAsync<UpdateAccountInfoCommand, UserDto>
            (command);
    }
}
