using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Adapter.Interface
{
    public interface IValidateToken
    {
        bool CheckValidToken(string customerID,string Token);
    }
}
