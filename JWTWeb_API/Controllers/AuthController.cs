﻿using JWTWeb_API.Model;
using JWTWeb_API.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTWeb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user=new User();
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration= configuration;
        }

        [HttpPost("Register")]
        public ActionResult<UserDto> Register(UserDto request)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.password);
            user.UserName=request.UserName;
            user.PasswordHash=passwordHash;

            return Ok(user);
        }


        [HttpPost("login")]
        public ActionResult<UserDto> login(UserDto request)
        {
            if (user.UserName != request.UserName)
            {
                return BadRequest("user Not Found");
            }
            if (!BCrypt.Net.BCrypt.Verify(request.password, user.PasswordHash)) {
                return BadRequest("Wrong Passwords");
            }

            return Ok(user);
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSetting:Token").Value!
                ));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var Token = new JwtSecurityToken(
                claims: claims,
                expires:DateTime.Now.AddDays(1),
                signingCredentials: cred
                );

            var jwt= new JwtSecurityTokenHandler().WriteToken(Token);

            return jwt;
        }
    }
}
