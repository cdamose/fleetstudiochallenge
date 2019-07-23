using MovieAPI.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.DataAccess.Interface
{
    public interface IMovie
    {
        List<MovieList> GetMovieLists();
        List<MovieList> GetRecommandedMovies(string customerID);


    }
}
