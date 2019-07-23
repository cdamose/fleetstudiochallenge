using System;
using System.Collections.Generic;

namespace MovieAPI.DBContext
{
    public partial class MovieGenerics
    {
        public MovieGenerics()
        {
            MovieList = new HashSet<MovieList>();
            UserIntrestedGenerics = new HashSet<UserIntrestedGenerics>();
        }

        public string Id { get; set; }
        public decimal? MovieGenerics1 { get; set; }
        public DateTime? CreatedDate { get; set; }

        public ICollection<MovieList> MovieList { get; set; }
        public ICollection<UserIntrestedGenerics> UserIntrestedGenerics { get; set; }
    }
}
