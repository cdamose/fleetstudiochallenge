using DataAccess.Interface;
using MovieAPI.DataAccess.Interface;
using MovieAPI.DBContext;
using MovieAPI.DTO.Request;
using MovieAPI.DTO.Response;
using MovieAPI.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.DataAccess
{
    public class UsersToken : IUsersToken
    {
        public Token GenerateToken(TokenRequest req)
        {
            IUser userObj = new User();
            var user= userObj.GetUsers(req.UserName);
            IDDBContext db = new IDDBContext();
            DBContext.UsersToken data = new DBContext.UsersToken
            {
                UserId = user.Id,
                AccessTokenLifeTime = 1000000, //it's currently chardcoded here
                AcessTokenCreatedDate = DateTime.Now,
                RefreshTokenCretaedDate = DateTime.Now,
                AccessToken = TokenHelper.GetInstance().GetAccessToken(),
                RefreshToken = TokenHelper.GetInstance().GetRefreshToken()
            };
            db.UsersToken.Add(data);
            db.SaveChanges();
            return new Token {
                AccessToken =data.AccessToken,
                RefreshToken=data.RefreshToken,
                CreatedAT=data.AcessTokenCreatedDate
            };


        }

        public DBContext.UsersToken GetUsersToken(string CustomerID,string token)
        {
            IDDBContext db = new IDDBContext();
            return db.UsersToken.Where(o => o.UserId == CustomerID && o.AccessToken==token).Select(o => o).SingleOrDefault();

        }
    }
}
