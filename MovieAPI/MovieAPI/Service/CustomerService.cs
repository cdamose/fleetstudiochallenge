using MovieAPI.Adapter;
using MovieAPI.Adapter.Interface;
using MovieAPI.DTO.Request;
using MovieAPI.DTO.Response;
using MovieAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Service
{
    public class CustomerService : ICustomerService
    {
        public CommonResponse RegisterCustomer(Customer request)
        {
            IRegistration adapter = new RegistrationAdapter();
            return adapter.RegisterCustomer(request);
        }
    }
}
