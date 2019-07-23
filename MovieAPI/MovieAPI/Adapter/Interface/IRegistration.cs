using MovieAPI.DTO;
using MovieAPI.DTO.Request;
using MovieAPI.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Adapter.Interface
{
    public interface IRegistration
    {
        CommonResponse RegisterCustomer(Customer req);
    }
}
