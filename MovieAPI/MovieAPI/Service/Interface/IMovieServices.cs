using MovieAPI.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Service.Interface
{
    public  interface IMovieServices
    {
        List<MovieList> GetMovieLists(string customerID);
    }
}
