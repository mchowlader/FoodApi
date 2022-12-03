using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MitraDinner.Contracts.Authenticaion;

namespace MitraDinner.APi.Controllers
{
    [Route("api/auth")]
    [ApiController]
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
}