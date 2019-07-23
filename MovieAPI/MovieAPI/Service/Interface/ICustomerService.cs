using MovieAPI.DTO.Request;
using MovieAPI.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Service.Interface
{
    public interface ICustomerService
    {
        CommonResponse RegisterCustomer(Customer request);
    }
}
