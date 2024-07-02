using JWTWeb_API.Model;
using JWTWeb_API.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTWeb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user=new User();

        [HttpPost("Register")]
        public ActionResult<UserDto> Register(UserDto request)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.password);
            user.UserName=request.UserName;
            user.PasswordHash=passwordHash;

            return Ok(user);
        }
    }
}
