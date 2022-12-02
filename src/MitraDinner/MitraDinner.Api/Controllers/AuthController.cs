using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MitraDinner.Contracts.Authentication;

namespace MitraDinner.Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            return Ok(request);
        }
    }
}
