using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using WebAPI.Models;
namespace WebAPI.Models
{
    public interface IJwtAuthenticationManager
    {
        UserDetails Authenticate(string Username, string Password);
    }

    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
        private UsersModel _UsersModel = new UsersModel();
        private readonly string Key;
        private readonly IRefreshTokenGenerator refreshTokenGenerator;

        public JwtAuthenticationManager(string Key, IRefreshTokenGenerator  refreshTokenGenerator)
        {
            this.Key = Key;
            this.refreshTokenGenerator = refreshTokenGenerator;
        }

        public UserDetails Authenticate(string Username, string Password)
        {
            if (!(_UsersModel.UsersList.Any(t => t.Username == Username && t.Password == Password)))
            {
                return new UserDetails()
                {
                    username = null,
                    email = null,
                    full_name = null,
                    id = 0,
                    mobile = null,
                    token = null,
                    message = "invalid username & password"
                };
            }
            else
            {
                var TokenHandler = new JwtSecurityTokenHandler();
                var TokenKey = Encoding.ASCII.GetBytes(Key);
                var TokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]{
                        new Claim(ClaimTypes.Name,Username)
                    }),
                    Expires = DateTime.Now.AddMinutes(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(TokenKey),
                    SecurityAlgorithms.HmacSha256Signature
                    )
                };
                var token = TokenHandler.CreateToken(TokenDescriptor);
                //return TokenHandler.WriteToken(token);
                RefrshTokenGenerator refrshTokenGenerator = new RefrshTokenGenerator();
                return new UserDetails()
                {
                    username = Username,
                    email = "saabir@yahoo.com",
                    full_name = "Saabir khan",
                    id = 500,
                    mobile = "xxxxxxx",
                    token = TokenHandler.WriteToken(token),
                    ref_token = refrshTokenGenerator.GenerateRefreshToken(),
                    message = "successfully loggedin"
                };
            }
        }
    }

    class Users
    {
        public string Username { set; get; }
        public string Password { set; get; }
    }
    class UsersModel
    {
        public List<Users> UsersList = new List<Users>()
        {
         new Users (){ Username ="test1", Password="testpass1"},
         new Users (){ Username ="test2", Password="testpass2"}
        };
    }
}

