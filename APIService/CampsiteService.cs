using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Threading.Tasks;

namespace APIService
{
    [DataContract]
    public class Campsite
    {
        [DataMember(Name = "CampsiteID")]
        public string Id { get; set; }

        [DataMember(Name = "CampsiteName")]
        public string Name { get; set; }

        [DataMember(Name = "CampsiteType")]
        public string Type { get; set; }

        [DataMember(Name = "CampsiteLatitude")]
        public double? Latitude { get; set; }

        [DataMember(Name = "CampsiteLongitude")]
        public double? Longitude { get; set; }

        [DataMember(Name = "CampsiteAccessible")]
        public bool Accessible { get; set; }
    }

    [DataContract]
    internal class CampsiteResponse
    {
        [DataMember(Name = "RECDATA", IsRequired = true)]
        public List<Campsite> Records { get; set; }
    }

    public interface ICampsiteService
    {
        Task<IReadOnlyList<Campsite>> GetCampsitesAsync(
            CancellationToken cancellationToken);
    }

    public sealed class CampsiteService : ICampsiteService
    {
        private static readonly Uri Endpoint = new Uri(
            "https://ridb.recreation.gov/api/v1/campsites?limit=50");

        private readonly HttpClient client;
        private readonly string apiKey;

        public CampsiteService(HttpClient client, string apiKey)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentException("An RIDB API key is required.", nameof(apiKey));

            this.client = client;
            this.apiKey = apiKey;
        }

        public async Task<IReadOnlyList<Campsite>> GetCampsitesAsync(
            CancellationToken cancellationToken)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, Endpoint))
            {
                request.Headers.Add("apikey", apiKey);

                using (var response = await client.SendAsync(
                    request, cancellationToken).ConfigureAwait(false))
                {
                    response.EnsureSuccessStatusCode();

                    using (var stream = await response.Content.ReadAsStreamAsync()
                        .ConfigureAwait(false))
                    {
                        var serializer = new DataContractJsonSerializer(
                            typeof(CampsiteResponse));
                        var result = (CampsiteResponse)serializer.ReadObject(stream);

                        if (result == null || result.Records == null)
                            throw new SerializationException(
                                "The RIDB response did not contain campsite records.");

                        return result.Records;
                    }
                }
            }
        }
    }
}
