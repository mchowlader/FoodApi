using Microsoft.AspNetCore.Mvc;
using MitraDinner.Contracts.Authentication;

namespace MitraDinner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticaionController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok(request);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        return Ok(request);
    }
}