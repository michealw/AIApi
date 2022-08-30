using Newtonsoft.Json;

namespace AIApi
{
    /// <summary>
    /// Data model for the Airport result.
    /// </summary>
    public partial class Airport : IDisposable
    {
        /// <summary>
        /// Database ID.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; } = 0;

        /// <summary>
        /// Three-letter IATA code.
        /// </summary>
        /// <example>CMH</example>
        [JsonProperty("iata")]
        public string? Iata { get; set; }

        /// <summary>
        /// Four-letter ICAO code.
        /// </summary>
        /// <example>KCMH</example>
        [JsonProperty("icao")]
        public string? Icao { get; set; }

        /// <summary>
        /// Full name of the airport.
        /// </summary>
        /// <example>John Glenn Columbus International Airport</example>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Location of the airport.
        /// </summary>
        /// <example>Columbus, Ohio, United States</example>
        [JsonProperty("location")]
        public string? Location { get; set; }
        
        /// <summary>
        /// Street number of the airport.
        /// </summary>
        /// <example>4600</example>
        [JsonProperty("street_number")]
        public string? StreetNumber { get; set; }

        /// <summary>
        /// Name of the street the airport sits on.
        /// </summary>
        /// <example>International Gateway</example>
        [JsonProperty("street")]
        public string? Street { get; set; }

        /// <summary>
        /// City (or other local political subdivision) the airport is in.
        /// </summary>
        /// <example>Columbus</example>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// County (or other political subdivision) the airport is in.
        /// </summary>
        /// <example>Franklin County</example>
        [JsonProperty("county")]
        public string? County { get; set; }

        /// <summary>
        /// State (or other political division) the airport is in.
        /// </summary>
        /// <example>Ohio</example>
        [JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// ISO 3166-2 formatted country code.
        /// </summary>
        /// <example>US</example>
        [JsonProperty("country_iso")]
        public string? CountryIso { get; set; }

        /// <summary>
        /// Full name of the country the airport is in.
        /// </summary>
        /// <example>United States</example>
        [JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Postal code the airport is in.
        /// </summary>
        /// <example>43219</example>
        [JsonProperty("postal_code")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// Public phone number of the airport.
        /// </summary>
        /// <example>+1 614-239-4000</example>
        [JsonProperty("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Latitude coordinate of the airport.
        /// </summary>
        /// <example>39.99994</example>
        [JsonProperty("latitude")]
        public double? Latitude { get; set; } = 0.0;

        /// <summary>
        /// Longitude coordinate of the airport.
        /// </summary>
        /// <example>-82.88718</example>
        [JsonProperty("longitude")]
        public double? Longitude { get; set; } = 0.0;

        [JsonProperty("uct")]
        public long? Uct { get; set; } = 0;

        /// <summary>
        /// Airport website.
        /// </summary>
        /// <example>http://flycolumbus.com</example>
        [JsonProperty("website")]
        public Uri? Website { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
