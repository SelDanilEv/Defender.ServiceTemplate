using Defender.ServiceTemplate.Domain.Entities;

namespace Defender.ServiceTemplate.Application.Common.Interfaces.Repositories;

public interface IDomainModelRepository
{
    Task<IList<DomainModel>> GetAllDomainModelsAsync();
    Task<DomainModel> GetDomainModelByIdAsync(Guid id);
    Task<DomainModel> CreateDomainModelAsync(DomainModel model);
    Task<DomainModel> UpdateDomainModelAsync(DomainModel updatedModel);
    Task RemoveDomainModelAsync(Guid id);
}
