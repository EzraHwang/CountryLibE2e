using Newtonsoft.Json;

namespace CountryLibE2e.Api.Models;

public class Country
{
    [JsonProperty("name")]
    public Name Name { get; set; }

    [JsonProperty("independent")]
    public bool Independent { get; set; }

    [JsonProperty("timezones")]
    public List<string> Timezones { get; set; }
}

public class Name
{
    [JsonProperty("common")]
    public string Common { get; set; }

    [JsonProperty("official")]
    public string Official { get; set; }
}