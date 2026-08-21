using _13_Aug_2026.Model;
using _13_Aug_2026.Repositary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _13_Aug_2026.Controllers
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
        public IActionResult Login(Customer customer)
        {
            var token = service.Login(customer.Name, customer.Password);
            if (token == null)

                return Unauthorized("Invalid username or passward");

            return Ok(new { token = token });
        }
    }
}
