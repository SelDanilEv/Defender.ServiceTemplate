using AutoMapper;
using Defender.Common.Wrapper;
using Defender.ServiceTemplate.Application.Common.Interfaces.Wrapper;
using Defender.ServiceTemplate.Infrastructure.Clients.ServiceClient.Generated;

namespace Defender.ServiceTemplate.Infrastructure.Clients.ServiceClient;

public class ServiceWrapper : BaseSwaggerWrapper, IServiceWrapper
{
    private readonly IMapper _mapper;
    private readonly IServiceClient _serviceClient;

    public ServiceWrapper(
        IServiceClient serviceClient,
        IMapper mapper)
    {
        _serviceClient = serviceClient;
        _mapper = mapper;
    }

    public Task DoWrap()
    {
        throw new NotImplementedException();
    }
}
