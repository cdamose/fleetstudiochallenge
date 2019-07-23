using MovieAPI.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Adapter.Interface
{
   public interface IMovieData
    {
        List<MovieList> GetRecomanndedMovie(string customerID);
        
    }
}
