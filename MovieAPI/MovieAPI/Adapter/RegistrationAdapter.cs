using DataAccess.Interface;
using MovieAPI.Adapter.Interface;
using MovieAPI.DataAccess;
using MovieAPI.DTO.Request;
using MovieAPI.DTO.Response;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Adapter
{
    public class RegistrationAdapter : IRegistration
    {
        public CommonResponse RegisterCustomer(Customer req)
        {
            CommonResponse response = new CommonResponse();
            try
            {
                IUser user = new User();
                response.IsSuccess= user.SaveCustomer(req);
                response.StatusCode = 200;
                return response;
            }
            catch(Exception e)
            {
                response.IsSuccess = false;
                response.StatusCode = 500;
                return response;
            }

            

            
        }
    }
}
