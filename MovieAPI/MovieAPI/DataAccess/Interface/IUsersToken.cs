using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.DataAccess.Interface
{
    public interface IUsersToken
    {
        MovieAPI.DBContext.UsersToken GetUsersToken(string CustomerID);
    }
}
