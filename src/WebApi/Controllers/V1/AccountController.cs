using System.Threading.Tasks;
using AutoMapper;
using Defender.Common.Attributes;
using Defender.Common.Consts;
using Defender.ServiceTemplate.Application.Modules.Module.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.V1;

public class AccountController : BaseApiController
{
    public AccountController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
    {
    }

    [HttpPost("block")]
    [Auth(Roles.Admin)]
    [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    public async Task BlockUserAsync([FromBody] ModuleCommand command)
    {
        await ProcessApiCallAsync(command);
    }

}
