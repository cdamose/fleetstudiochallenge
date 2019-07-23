using DataAccess.Interface;
using MovieAPI.DBContext;
using MovieAPI.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.DataAccess
{
    public class User : IUser
    {
        public Users GetUsers(string username)
        {
            try
            {
                MovieDBContext db = new MovieDBContext();
                return db.Users.Where(o => o.Mobile == username || o.Email == username).Select(o => o).First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool SaveCustomer(Customer req)
        {
            try
            {
                Users user_obj = new Users();
                user_obj.Id = Guid.NewGuid().ToString();
                user_obj.Email = req.Email;
                user_obj.IsVerified = false;
                user_obj.Mobile = req.MobileNumber;
                user_obj.Name = req.Name;
                MovieDBContext db = new MovieDBContext();
                db.Users.Add(user_obj);
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }
    }
}
