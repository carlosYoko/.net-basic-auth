using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IBeerService
{
    public Task<List<Beer>> Get();
}