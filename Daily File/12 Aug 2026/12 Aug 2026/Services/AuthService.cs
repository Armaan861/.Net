using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using _12_Aug_2026.Data;
using _12_Aug_2026.Reposatary;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
namespace _12_Aug_2026.Services
{
    public class AuthService : IAuthService
    {

        private readonly AppDbContext context;
        private readonly IConfiguration configuration;

        public AuthService(AppDbContext context , IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public string? Login(string username, string passward)
        {
            //find user 
            var user = context.Users.FirstOrDefault(
                u => u.UserName == username && u.Password == passward);
            //invalid User/ PassWard
            if (user == null)
                return null;


            // Create claims
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role)
            };




            //Get JwT Key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!));

            //credentails
            var credentails = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);


            // create jwt
            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentails
            );

            //convert token to string 
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
