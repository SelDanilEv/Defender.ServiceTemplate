using Rentel.ServiceTemplate.Application.Common.Interfaces;
using Rentel.ServiceTemplate.Application.Common.Interfaces.Repositories;
using Rentel.ServiceTemplate.Application.Common.Models.Sample;
using Rentel.ServiceTemplate.Infrastructure.Clients.Interfaces;

namespace Rentel.ServiceTemplate.Infrastructure.Services;

public class SampleService : ISampleService
{
    private readonly ISampleClient _sampleClient;
    private readonly ISampleRepository _sampleRepository;

    public SampleService(
        ISampleClient sampleClient,
        ISampleRepository sampleRepository)
    {
        _sampleClient = sampleClient;
        _sampleRepository = sampleRepository;
    }

    public async Task<SampleResponse> GetSampleAsync()
    {
        await _sampleRepository.GetAllSamplesAsync();

        return await _sampleClient.GetSampleAsync();
    }
}
