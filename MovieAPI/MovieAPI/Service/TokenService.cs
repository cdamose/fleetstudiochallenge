using MovieAPI.Adapter;
using MovieAPI.Adapter.Interface;
using MovieAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Service
{
    public class TokenService : ITokenService
    {
        public bool ValidateToken(string customerID, string Token)
        {
            IValidateToken tokenService = new TokenAdapter();
            return tokenService.CheckValidToken(customerID,  Token);
        }
    }
}
