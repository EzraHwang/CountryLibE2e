using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
#pragma warning disable CS8603 // Possible null reference return.

namespace CountryLibE2e.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CountryLibController : ControllerBase
{
    private readonly ILogger<CountryLibController> _logger;
    private readonly ICountryLibService _countryLibService;

    public CountryLibController(ILogger<CountryLibController> logger, ICountryLibService countryLibService)
    {
        _logger = logger;
        _countryLibService = countryLibService;
    }

    [HttpGet(Name = "Get")]
    public async Task<IEnumerable<Country>> Get()
    {
        return await _countryLibService.Get();
    }
}

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

public interface ICountryLibService
{
    Task<IEnumerable<Country>> Get();
}

public class CountryLibService : ICountryLibService
{
    private readonly HttpClient _httpClient;

    public CountryLibService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Country>> Get()
    {
        var responseMessage = await _httpClient.GetAsync("https://restcountries.com/v3.1/all");
        if (!responseMessage.IsSuccessStatusCode) return new List<Country>();
        var content = await responseMessage.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<IEnumerable<Country>>(content);

    }
}