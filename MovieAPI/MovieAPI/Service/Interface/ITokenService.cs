using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Service.Interface
{
    public interface ITokenService
    {
        bool ValidateToken(string customerID, string Token);
    }
}
