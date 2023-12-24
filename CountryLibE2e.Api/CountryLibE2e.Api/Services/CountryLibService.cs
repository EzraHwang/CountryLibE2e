using CountryLibE2e.Api.Models;
using CountryLibE2e.Api.Repositories.Interfaces;
using CountryLibE2e.Api.Services.Interfaces;
using Newtonsoft.Json;

#pragma warning disable CS8603 // Possible null reference return.

namespace CountryLibE2e.Api.Services;

public class CountryLibService : ICountryLibService
{
    private readonly HttpClient _httpClient;
    private readonly ICountryLibRepository _countryLibRepository;

    public CountryLibService(HttpClient httpClient, ICountryLibRepository countryLibRepository)
    {
        _httpClient = httpClient;
        _countryLibRepository = countryLibRepository;
    }

    public async Task<IEnumerable<Country>> ApiGet()
    {
        var responseMessage = await _httpClient.GetAsync("https://restcountries.com/v3.1/all");
        if (!responseMessage.IsSuccessStatusCode) return new List<Country>();
        var content = await responseMessage.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<IEnumerable<Country>>(content);
    }

    public IEnumerable<Country> DbGet()
    {
        return _countryLibRepository.GetCountryInfo();
    }
}