using Defender.ServiceTemplate.Application.Common.Interfaces;
using Defender.ServiceTemplate.Application.Common.Interfaces.Repositories;

namespace Defender.ServiceTemplate.Application.Services;

public class Service(
    IDomainModelRepository accountInfoRepository) : IService
{
    public Task DoService()
    {
        throw new NotImplementedException();
    }
}
