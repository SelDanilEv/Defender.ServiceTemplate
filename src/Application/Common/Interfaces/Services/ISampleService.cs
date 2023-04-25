using Defender.ServiceTemplate.Application.Models.Sample;

namespace Defender.ServiceTemplate.Application.Common.Interfaces;

public interface ISampleService
{
    Task<SampleResponse> GetSampleAsync();
}
