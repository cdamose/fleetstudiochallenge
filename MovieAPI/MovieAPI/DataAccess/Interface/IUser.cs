using MovieAPI.DBContext;
using MovieAPI.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
   public interface IUser
    {
        Users GetUsers(string username);
        bool SaveCustomer(Customer req);
    }
}
