using Rentel.ServiceTemplate.Domain.Entities.Sample;

namespace Rentel.ServiceTemplate.Application.Common.Interfaces.Repositories;

public interface ISampleRepository
{
    Task<IList<SampleModel>> GetAllSamplesAsync();
    Task<SampleModel> GetSampleByIdAsync(Guid id);
    Task<SampleModel> CreateSampleAsync(SampleModel sample);
    Task<SampleModel> UpdateSampleAsync(SampleModel updatedSample);
    Task RemoveSampleAsync(Guid id);
}
