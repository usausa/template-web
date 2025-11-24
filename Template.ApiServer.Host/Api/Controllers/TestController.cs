namespace Template.ApiServer.Host.Api.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public sealed class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Execute()
    {
        return Ok();
    }
}
