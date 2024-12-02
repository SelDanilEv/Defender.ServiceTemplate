using Defender.ServiceTemplate.Application.Common.Interfaces.Repositories;
using Defender.ServiceTemplate.Application.Common.Interfaces.Services;

namespace Defender.ServiceTemplate.Application.Services;

public class Service(
    IDomainModelRepository accountInfoRepository) : IService
{
    public Task DoService()
    {
        throw new NotImplementedException();
    }
}
