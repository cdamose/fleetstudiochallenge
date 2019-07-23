using System;
using System.Collections.Generic;

namespace MovieAPI.DBContext
{
    public partial class Client
    {
        public string ClientId { get; set; }
        public string ClientSecrect { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
