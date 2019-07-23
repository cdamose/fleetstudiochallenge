using System;
using System.Collections.Generic;

namespace MovieAPI.DBContext
{
    public partial class MovieList
    {
        public string Id { get; set; }
        public string MovieName { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string ActorName { get; set; }
        public string ActresName { get; set; }
        public string GenricType { get; set; }

        public MovieGenerics GenricTypeNavigation { get; set; }
    }
}
