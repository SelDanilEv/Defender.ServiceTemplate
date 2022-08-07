using Defender.ServiceTemplate.Application.Common.Interfaces.Repositories;
using Defender.ServiceTemplate.Application.Configuration.Options;
using Defender.ServiceTemplate.Domain.Entities.Sample;
using Microsoft.Extensions.Options;

namespace Defender.ServiceTemplate.Infrastructure.Repositories.Sample;

public class SampleRepository : MongoRepository<SampleModel>, ISampleRepository
{
    public SampleRepository(IOptions<MongoDbOption> mongoOption) : base(mongoOption.Value)
    {
    }

    public async Task<IList<SampleModel>> GetAllSamplesAsync()
    {
        return await GetItemsAsync();
    }

    public async Task<SampleModel> GetSampleByIdAsync(Guid id)
    {
        return await GetItemAsync(id);
    }

    public async Task<SampleModel> CreateSampleAsync(SampleModel sample)
    {
        return await AddItemAsync(sample);
    }

    public async Task<SampleModel> UpdateSampleAsync(SampleModel updatedSample)
    {
        return await UpdateItemAsync(updatedSample);
    }

    public async Task RemoveSampleAsync(Guid id)
    {
        await RemoveItemAsync(id);
    }
}
