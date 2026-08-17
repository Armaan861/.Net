using System.Security.Claims;
using _13_Aug_2026.Data;
using _13_Aug_2026.Repositary;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace _13_Aug_2026.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext context;
        private readonly IConfiguration configuration;

        public AuthService(
            AppDbContext context,
            IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        public string? Login(string username, string passward)
        {
            // Find user
            var customer = context.Customers.FirstOrDefault(
                c => c.Name == username && c.Password == passward);

            // Invalid User / Password
            if (customer == null)
                return null;

            // Create claims
            var claims = new[]
            {
                new Claim(
                    ClaimTypes.NameIdentifier,
                    customer.Id.ToString()),

                new Claim(
                    ClaimTypes.Name,
                    customer.Name),

               new Claim(
    ClaimTypes.Role,
    customer.Role)
            };

            // Get JWT Key
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                    configuration["Jwt:Key"]!));

            // Credentials
            var credentials = new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256);

            // Create JWT
            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials
            );

            // Convert token to string
            return new JwtSecurityTokenHandler()
                .WriteToken(token);
        }
    }
}