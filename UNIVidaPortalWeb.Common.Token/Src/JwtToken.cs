using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace UNIVidaPortalWeb.Common.Token.Src
{
    public static class JwtToken
    {
        public static string Create(JwtOptions configuration, List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var token = new JwtSecurityToken(
                issuer: configuration.Issuer,
                audience: configuration.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(configuration.Expiration)),
                signingCredentials: creds
            );

            string _token = new JwtSecurityTokenHandler().WriteToken(token);

            return _token;
        }
    }
}
