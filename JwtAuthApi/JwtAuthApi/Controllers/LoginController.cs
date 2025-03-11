using JwtAuthApi.Models;
using JwtAuthApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public LoginController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserModel user)
        {
            return Ok("User registered successfully.");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserModel user)
        {
            if (user.Username == "admin" && user.Password == "password")
            {
                var token = _jwtService.GenerateToken(user.Username);
                return Ok(new { Token = token });
            }
            return Unauthorized("Invalid credentials.");
        }
    }
}
