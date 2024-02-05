using Microsoft.AspNetCore.Mvc;

namespace signalr_example.Controllers;

[ApiController]
[Route("/connect")]
public class ConnectionController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Hello() {
        return Ok( "Hello, world!" );
    }
}
