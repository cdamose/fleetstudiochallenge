using System;
using System.Collections.Generic;

namespace MovieAPI.DBContext
{
    public partial class UserIntrestedGenerics
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserIntrestId { get; set; }
        public DateTime CreatedDate { get; set; }

        public MovieGenerics UserIntrest { get; set; }
    }
}
