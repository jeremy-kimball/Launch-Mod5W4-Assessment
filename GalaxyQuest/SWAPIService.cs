using System.Text.Json;
using GalaxyQuest.Models;

namespace GalaxyQuest
{
    public class SWAPIService : ISWAPIService
    {
        private static readonly HttpClient client;

        static SWAPIService()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://swapi.dev/api/")
            };
        }

        public async Task<List<PlanetModel>> GetPlanets()
        {
            var url = string.Format("planets/");
            var result = new List<PlanetModel>();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<List<PlanetModel>>(stringResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return result;
        }
    }
}
