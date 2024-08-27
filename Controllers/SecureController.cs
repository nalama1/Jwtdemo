using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecureController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetSecretData()
        {
            return Ok("This is a secret message!");
        }
    }
}
