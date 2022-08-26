using System.Net.Http.Headers;
using Defender.ServiceTemplate.Application.Common.Exceptions;
using Defender.ServiceTemplate.Application.Models.Sample;
using Defender.ServiceTemplate.Infrastructure.Clients.Interfaces;
using Newtonsoft.Json;

namespace Defender.ServiceTemplate.Infrastructure.Clients;

public partial class SampleClient : ISampleClient
{
    private readonly HttpClient _httpClient;

    public SampleClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<SampleResponse> GetSampleAsync()
    {
        var url = $"/";

        var client = _httpClient;
        try
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);

                var response = await client.SendAsync(request);

                if ((int)response.StatusCode == 200)
                {
                    var responseText = await response.Content.ReadAsStringAsync();

                    try
                    {
                        return JsonConvert.DeserializeObject<SampleResponse>(responseText);
                    }
                    catch (JsonSerializationException exception)
                    {
                        var message =
                            "Could not deserialize the response body string as " +
                            typeof(SampleResponse).FullName + ".";
                        throw new InvalidCastException(message);
                    }
                }

                throw new CustomSampleException();
            }
        }
        finally
        {
            client.Dispose();
        }
    }

}
