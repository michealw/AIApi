using Newtonsoft.Json;

namespace AIApi
{
    public partial class Airport : IDisposable
    {
        [JsonProperty("id")]
        public long Id { get; set; } = 0;

        [JsonProperty("iata")]
        public string? Iata { get; set; }

        [JsonProperty("icao")]
        public string? Icao { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("location")]
        public string? Location { get; set; }

        [JsonProperty("street_number")]
        public string? StreetNumber { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("county")]
        public string? County { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("country_iso")]
        public string? CountryIso { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("postal_code")]
        public string? PostalCode { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; } = 0.0;

        [JsonProperty("longitude")]
        public double? Longitude { get; set; } = 0.0;

        [JsonProperty("uct")]
        public long? Uct { get; set; } = 0;

        [JsonProperty("website")]
        public Uri? Website { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
