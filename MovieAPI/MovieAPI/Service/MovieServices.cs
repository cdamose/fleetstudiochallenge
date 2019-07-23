using MovieAPI.Adapter;
using MovieAPI.Adapter.Interface;
using MovieAPI.DBContext;
using MovieAPI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Service
{
    public class MovieServices : IMovieServices
    {
        public List<MovieList> GetMovieLists(string customerID)
        {
            IMovieData adapter = new MovieDataAdapter();
            return adapter.GetRecomanndedMovie(customerID);
        }
    }
}
