using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Entity_Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Entity_Db.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _config;
        private readonly Jwt_databaseContext _context;

        public TokenController(IConfiguration config, Jwt_databaseContext context)
        {
            _config = config;
            _context = context;
        }

        /////[HttpGet]
        private Login GetUser(string username, string password,string role)
        {
            return _context.Login.FirstOrDefault(u => u.Username == username && u.Password == password && u.Role==role);
        }
        [HttpPost]
        public IActionResult Detail(Login login)
        {
            var user = GetUser(login.Username, login.Password,login.Role);
            if (user != null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Role,"admin"),
                    

                };
               

                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);



                var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(20),
                signingCredentials: credentials);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));


            }
            else
            {
                return BadRequest("Invalid Credentials");
            }

        }

    }
}