using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace KataTest;

[ApiController]
[Route("health")]
public class HealthController:ControllerBase
{
    [HttpGet]
    public IActionResult Check()
    {
        return Ok($"Api is running");
    }
}