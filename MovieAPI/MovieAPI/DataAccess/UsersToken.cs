﻿using MovieAPI.DataAccess.Interface;
using MovieAPI.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.DataAccess
{
    public class UsersToken : IUsersToken
    {
        public DBContext.UsersToken GetUsersToken(string CustomerID)
        {
            IDDBContext db = new IDDBContext();
            return db.UsersToken.Where(o => o.UserId == CustomerID).Select(o => o).Single();

        }
    }
}