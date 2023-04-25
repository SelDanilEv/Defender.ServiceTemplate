using Defender.ServiceTemplate.Application.Common.Interfaces;
using Defender.ServiceTemplate.Application.Common.Interfaces.Repositories;
using Defender.ServiceTemplate.Application.Models.Sample;
using Defender.ServiceTemplate.Infrastructure.Clients.Interfaces;

namespace Defender.ServiceTemplate.Infrastructure.Services;

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
