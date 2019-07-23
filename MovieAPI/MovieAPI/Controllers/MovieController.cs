using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Service;
using MovieAPI.Service.Interface;

namespace MovieAPI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult GetRecomandedMovies(string customerID)
        {
            IMovieServices services = new MovieServices();
            var list= services.GetMovieLists(customerID);
            return new JsonResult(list);
        }
    }
}