using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.DTO.Request
{
    public class TokenRequest
    {
        public String ClientID { get; set; }
        public String ClientSecrect { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
    }
}
