using Defender.ServiceTemplate.Application.Models.Sample;

namespace Defender.ServiceTemplate.Infrastructure.Clients.Interfaces;
public interface ISampleClient
{
    Task<SampleResponse> GetSampleAsync();
}
