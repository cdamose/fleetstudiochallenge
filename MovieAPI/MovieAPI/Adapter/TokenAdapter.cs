using MovieAPI.Adapter.Interface;
using MovieAPI.DataAccess;
using MovieAPI.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Adapter
{
    public class TokenAdapter : IValidateToken
    {
        public bool CheckValidToken(string customerID,string Token)
        {
            IUsersToken tokenValidator = new UsersToken();
            var tokenObj= tokenValidator.GetUsersToken(customerID,Token);
            if (tokenObj == null)
            {
                return false;
            }
            //check token validity here 
            if(DateTime.Now>  tokenObj.AcessTokenCreatedDate.AddSeconds((int)tokenObj.AccessTokenLifeTime))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
