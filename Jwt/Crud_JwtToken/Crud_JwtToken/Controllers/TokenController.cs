using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Crud_JwtToken.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Crud_JwtToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IOptions<Connection> _connection;

        private IConfiguration _config;

        public TokenController(IConfiguration config, IOptions<Connection> connection)
        {
            _config = config;
            _connection = connection;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult CreateToken(string role)
        {
            Employee login = new Employee();
            
            IActionResult response = Unauthorized();


            var user = Authenticate(login);

            if (user.Role==role)
            {
                var tokenString = BuildToken(user);
                response = Ok(new { token = tokenString });

                return response;

            }
            

            else
             {
                 return Ok(BadRequest("wrong entries"));
             }

        }
        private string BuildToken(Employee user)
        {
            try
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var claims = new[]
                {
                new Claim(JwtRegisteredClaimNames.Sub,user.Name),
                 new Claim(JwtRegisteredClaimNames.Sub,user.Password),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role,user.Role)


            };

                var token = new JwtSecurityToken(
                  _config["Jwt:Issuer"],
                  _config["Jwt:Issuer"],
                  claims,
                  expires: DateTime.Now.AddMinutes(30),
                  signingCredentials: creds);

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
        private Employee Authenticate(Employee user)
        {
            try
            {
                user = new Employee();
                string con = _connection.Value.ConnectionString;
                SqlConnection sqlConnection = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("select Name,Password,Role from Employee", sqlConnection);
                sqlConnection.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    user.Name = rd["Name"].ToString();

                    user.Password = rd["Password"].ToString();

                    user.Role = rd["Role"].ToString();
                }
                return user;
            }
            catch (Exception)
            {

                throw;
            }

           
        }
    }
}