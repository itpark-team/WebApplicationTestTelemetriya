using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTestTelemetriya.Controllers;

[ApiController]
[Route("other/")]
public class OtherController : ControllerBase
{
    [HttpGet("get-int")]
    public int GetInt()
    {
        return Random.Shared.Next(1, 100);
    }
}