using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.DTO.Request;
using MovieAPI.Service;
using MovieAPI.Service.Interface;

namespace MovieAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register(Customer request)
        {
            ICustomerService service = new CustomerService();
            return new JsonResult (service.RegisterCustomer(request));
        }
    }
}