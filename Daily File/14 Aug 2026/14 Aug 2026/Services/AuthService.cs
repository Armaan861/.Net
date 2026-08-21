using System.Security.Claims;
using _14_Aug_2026.Data;
using _14_Aug_2026.Repository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using System.Text;

namespace _14_Aug_2026.Services
{
    
    
        public class AuthService : IAuthService
        {

            private readonly AppDbContext context;
            private readonly IConfiguration configuration;

            public AuthService(AppDbContext context, IConfiguration configuration)
            {
                this.context = context;
                this.configuration = configuration;
            }
            public string? Login(string username, string passward)
            {
                //find user 
                var customer = context.Customers.FirstOrDefault(
                    c =>  c.Name == username && c.Passward == passward);
                //invalid User/ PassWard
                if (customer == null)
                    return null;

  // Create claims
    var claims = new[]
    {
        new Claim(ClaimTypes.NameIdentifier, customer.Id.ToString()),
        new Claim(ClaimTypes.Name, customer.Name),
        new Claim(ClaimTypes.Role, customer.Role)
    };




                //Get JwT Key
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!));

                //credentails
                var credentails = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //create jwt
                var token = new JwtSecurityToken(issuer: configuration["Jwt:Issuer"], audience: configuration["Jwt:Auidence"],
                    expires: DateTime.UtcNow.AddHours(1), signingCredentials: credentails);

                //convert token to string 
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
        }
    }

