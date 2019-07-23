using System;
using System.Collections.Generic;

namespace MovieAPI.Models
{
    public partial class Users
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool? IsVerified { get; set; }
    }
}
