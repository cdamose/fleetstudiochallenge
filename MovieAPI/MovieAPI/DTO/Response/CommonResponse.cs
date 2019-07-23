using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.DTO.Response
{
    public class CommonResponse
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
    }
}
