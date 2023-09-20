using Defender.ServiceTemplate.Application.Common.Interfaces.Repositories;
using Defender.ServiceTemplate.Application.Configuration.Options;
using Defender.ServiceTemplate.Domain.Entities;
using Microsoft.Extensions.Options;

namespace Defender.ServiceTemplate.Infrastructure.Repositories.DomainModels;

public class DomainModelRepository : MongoRepository<DomainModel>, IDomainModelRepository
{
    public DomainModelRepository(IOptions<MongoDbOptions> mongoOption) : base(mongoOption.Value)
    {
    }

    #region Default methods

    public async Task<IList<DomainModel>> GetAllDomainModelsAsync()
    {
        return await GetItemsAsync();
    }

    public async Task<DomainModel> GetDomainModelByIdAsync(Guid id)
    {
        return await GetItemAsync(id);
    }

    public async Task<DomainModel> CreateDomainModelAsync(DomainModel user)
    {
        return await AddItemAsync(user);
    }

    public async Task<DomainModel> UpdateDomainModelAsync(DomainModel updatedDomainModel)
    {
        return await UpdateItemAsync(updatedDomainModel);
    }

    public async Task RemoveDomainModelAsync(Guid id)
    {
        await RemoveItemAsync(id);
    }

    #endregion
}
