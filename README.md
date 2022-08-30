# AIApi

[![.NET](https://github.com/michealw/AIApi/actions/workflows/dotnet.yml/badge.svg)](https://github.com/michealw/AIApi/actions/workflows/dotnet.yml) [![CodeQL](https://github.com/michealw/AIApi/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/michealw/AIApi/actions/workflows/codeql-analysis.yml)

A C# library for accessing the [Airport Info API](https://rapidapi.com/Active-api/api/airport-info/) on [RapidAPI](https://rapidapi.com).

---
#### How to Use

Create the API key object.
```
var apiKey = new ApiKey("API_KEY_GOES_HERE", "airport-info.p.rapidapi.com");
```

Call the `GetAirportAsync` function. Use `ParameterType.Iata` if you're using a three-letter IATA code.
```
using (var airport = await AirportInfo.GetAirportAsync(apiKey, ParameterType.Icao, "KCMH"))
{
    
}
```