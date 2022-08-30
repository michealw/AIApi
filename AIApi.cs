using Newtonsoft.Json;

namespace AIApi
{
    public class AIApi
    {
        /// <summary>
        /// Gets the airport data for the provided code.
        /// </summary>
        /// <param name="key">ApiKey object containing the user's API key and host name.</param>
        /// <param name="type">Airport code type.</param>
        /// <param name="airport">Airport code to search for.</param>
        /// <returns>
        /// Airport object containing the requested data or null
        /// if the request returned an error.
        /// </returns>
        public static async Task<Airport?> GetAirportAsync(ApiKey key, ParameterType type, string airport)
        {
            var client = new HttpClient();
            using var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://airport-info.p.rapidapi.com/airport?{type.ToString().ToLower()}={airport}"),
                Headers =
                {
                    { "X-RapidAPI-Key", key.Key },
                    { "X-RapidAPI-Host", key.Host }
                }
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var airportData = JsonConvert.DeserializeObject<Airport>(jsonResponse);
                return airportData;
            }
        }
    }
}