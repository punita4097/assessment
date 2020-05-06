using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace crud_netcore.Shared
{
    public class AuthenticationConfig
    {
        public static string GenerateJsonWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("4C85867C0FF3F0B95B6A459B9D7CE9ABF7A9DA0DB8DA4BED3952FFB39B06B9D3"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] { new Claim("UserName", "Admin") };

            var token = new JwtSecurityToken("Punita", "http://localhost:5168", claims, DateTime.UtcNow,

              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
