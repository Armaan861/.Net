using _12_Aug_2026.Reposatary;
using Microsoft.AspNetCore.Authorization;
using _12_Aug_2026.Models;
using Microsoft.AspNetCore.Mvc;

namespace _12_Aug_2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService service;
        public AuthController(IAuthService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            var token = service.Login(user.UserName, user.Password);
            if (token == null)

                return Unauthorized("Invalid username or passward");

            return Ok(new { token = token });
        }
      
}

    }
