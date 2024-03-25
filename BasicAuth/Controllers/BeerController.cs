using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class BeerController : ControllerBase
{
    private readonly IBeerService _beerService;

    public BeerController(IBeerService beerService)
    {
        _beerService = beerService;
    }

    [HttpGet]
    public async Task<IEnumerable<Beer>> Get()
    {
        return await _beerService.Get();
    }
}