using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    interface IRefreshTokenGenerator
    {
        string GenerateRefreshToken();
    }
    public class RefrshTokenGenerator : IRefreshTokenGenerator
    {
        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var randomNumberGenerator =RandomNumberGenerator.Create())
            {
                return Convert.ToBase64String(randomNumber);
            }
        }
    }
}
