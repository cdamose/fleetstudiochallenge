﻿using MovieAPI.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
   public interface IUser
    {
        bool SaveCustomer(Customer req);
    }
}
