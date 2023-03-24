using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskSystem.Models;
using TaskSystem.Repository.Interfaces;

namespace TaskSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly AuthenticationPolicy _jwtAuthenticationManager;

        public AuthController(AuthenticationPolicy jwtAuthenticationManager)
        {
            _jwtAuthenticationManager = jwtAuthenticationManager;
        }

        [HttpPost("Authorize")]
        public IActionResult AuthUser([FromBody] User user)
        {
            var token = _jwtAuthenticationManager.Authenticate(user.username, user.password);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }


        public class User
        {
            public string username { get; set; }
            public string password { get; set; }
        }
    }
}
