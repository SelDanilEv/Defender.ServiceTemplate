using Rentel.ServiceTemplate.Application.Common.Models.Sample;

namespace Rentel.ServiceTemplate.Application.Common.Interfaces;

public interface ISampleService
{
    Task<SampleResponse> GetSampleAsync();
}
