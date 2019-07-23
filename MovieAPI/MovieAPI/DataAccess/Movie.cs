using MovieAPI.DataAccess.Interface;
using MovieAPI.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.DataAccess
{
    public class Movie : IMovie
    {
        public List<MovieList> GetRecommandedMovies(string customerID)
        {
            try
            {
                MovieDBContext db = new MovieDBContext();
                return db.UserIntrestedGenerics.Where(o => o.UserId == customerID).Select(o=>o.UserIntrest.MovieList).Single().ToList();
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public List<MovieList> GetMovieLists()
        {
            try
            {
                MovieDBContext db = new MovieDBContext();
                return db.MovieList.Select(o=>o).ToList();
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
