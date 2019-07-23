using MovieAPI.DTO.Request;
using MovieAPI.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Adapter.Interface
{
    public interface IValidateToken
    {
        Token GenerateToken(TokenRequest request);
        bool CheckValidToken(string customerID,string Token);
    }
}
