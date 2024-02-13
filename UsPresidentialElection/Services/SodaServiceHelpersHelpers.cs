using System.Text.Json;
using UsPresidentialElection.Models;

public class SodaService
{

    public static async Task<IEnumerable<LegallyOperatingBusinesses>> GetLegallyOperatingBusinesses()
    {
        using HttpClient client = new HttpClient();
        var data = await client.GetAsync("https://data.cityofnewyork.us/resource/w7w3-xahh.json");
        var dataAsString = await data.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<IEnumerable<LegallyOperatingBusinesses>>(dataAsString);
    }
}