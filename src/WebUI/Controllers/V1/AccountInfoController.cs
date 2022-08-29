using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Defender.ServiceTemplate.Application.Models.LoginResponse;
using Defender.ServiceTemplate.Application.Modules.Auth.Commands;
using Defender.ServiceTemplate.Application.DTOs;

namespace Defender.ServiceTemplate.WebUI.Controllers.V1;

public class AccountInfoController : BaseApiController
{
    public AccountInfoController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
    {
    }

    [HttpPut("update")]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task<UserDto> UpdateAccountInfoAsync(
        [FromBody] UpdateAccountInfoCommand command)
    {
        return await ProcessApiCallWithoutMappingAsync<UpdateAccountInfoCommand, UserDto>
            (command);
    }
}
