using MovieAPI.Adapter.Interface;
using MovieAPI.DataAccess;
using MovieAPI.DataAccess.Interface;
using MovieAPI.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Adapter
{
    public class MovieDataAdapter : IMovieData
    {
        public List<MovieList> GetRecomanndedMovie(string customerID)
        {
            IMovie movieDataAccess = new Movie();
            return  movieDataAccess.GetRecommandedMovies(customerID);

        }
    }
}
