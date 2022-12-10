using Rentel.ServiceTemplate.Application.Common.Models.Sample;

namespace Rentel.ServiceTemplate.Infrastructure.Clients.Interfaces;
public interface ISampleClient
{
    Task<SampleResponse> GetSampleAsync();
}
