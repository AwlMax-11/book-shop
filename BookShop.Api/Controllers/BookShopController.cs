using Microsoft.AspNetCore.Mvc;

namespace BookShop.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BookShopController : ControllerBase
{
    private readonly ILogger<BookShopController> _logger;

    public BookShopController(ILogger<BookShopController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBooks")]
    public async Task<IActionResult> Get()
    {
        return Ok("books");
    }
}