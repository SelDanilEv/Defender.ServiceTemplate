using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
public class BaseApiController(IMediator mediator, IMapper mapper) : ControllerBase
{
    protected async Task<TResult> ProcessApiCallAsync<TRequest, TResult>(TRequest request)
    {
        var response = await mediator.Send(request);

        var result = mapper.Map<TResult>(response);

        return result;
    }

    protected async Task ProcessApiCallAsync<TRequest>(TRequest request)
    {
        await mediator.Send(request);
    }

    protected async Task<TResult> ProcessApiCallWithoutMappingAsync<TRequest, TResult>(TRequest request)
    {
        var response = await mediator.Send(request);

        return (TResult)response;
    }
}
