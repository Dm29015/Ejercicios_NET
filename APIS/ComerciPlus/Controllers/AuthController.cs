using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ComerciPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] UserLogin model)
        {
            // Aquí deberías validar las credenciales del usuario
            // Si las credenciales son válidas, genera y retorna un token JWT
            if (model.Username == "admin" && model.Password == "1234")
            {
                var tokenString = GenerateJWTToken();
                return Ok(new { token = tokenString });
            }
            else
            {
                return Unauthorized(new { message = "Usuario y/o claves incorrectos" });
            }
        }

        [HttpPost]
        [Route("validate-token")]
        public IActionResult ValidateToken([FromBody] TokenValidationRequest request)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_config["Jwt:Key"]);

            try
            {
                tokenHandler.ValidateToken(request.Token, new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true, // Verifica si el token está vigente
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _config["Jwt:Issuer"],
                    ValidAudience = _config["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                }, out SecurityToken validatedToken);

                return Ok(new { message = "Token is valid" });
            }
            catch (SecurityTokenExpiredException)
            {
                return Unauthorized(new { message = "Token has expired" });
            }
            catch
            {
                return Unauthorized(new { message = "Invalid token" });
            }
        }


        private string GenerateJWTToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                null,
                expires: DateTime.Now.AddSeconds(30),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public class UserLogin
        {
            [Required]
            public required string Username { get; set; }

            [Required]
            public required string Password { get; set; }
        }

        public class TokenValidationRequest
        {
            [Required]
            public required string Token { get; set; }
        }
    }
}
