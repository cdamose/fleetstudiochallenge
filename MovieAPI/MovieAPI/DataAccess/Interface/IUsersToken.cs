using MovieAPI.DTO.Request;
using MovieAPI.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.DataAccess.Interface
{
    public interface IUsersToken
    {
        Token GenerateToken(TokenRequest req);
        MovieAPI.DBContext.UsersToken GetUsersToken(string CustomerID,string Token);
    }
}
