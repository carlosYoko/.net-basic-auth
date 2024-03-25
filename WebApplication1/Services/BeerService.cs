using WebApplication1.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace WebApplication1.Services;

public class BeerService : IBeerService
{
    private readonly string path = @"/home/carlos/Dev/varios/c#/Pruebas/WebApplication1/WebApplication1/beers.json";

    public async Task<List<Beer>> Get()
    {
        var content = await File.ReadAllTextAsync(path);
        var beers = JsonSerializer.Deserialize<List<Beer>>(content);

        return beers;
    }
}