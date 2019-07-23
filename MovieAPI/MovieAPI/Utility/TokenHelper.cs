using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Utility
{
    public class TokenHelper
    {
        public static TokenHelper Instance { get; set; }
        public static Object data { get; set; }

        public static TokenHelper GetInstance()
        {
            if (Instance == null) {
                lock (data)
                {
                    Instance = new TokenHelper();
                }
            }
            return Instance;
        }

        public string GetAccessToken()
        {
            return "zxhvsdjhvsdjhsdfvjhbdfg";//salt encryption logic will replace here 
        }
        public string GetRefreshToken()
        {
            return "zxhvsdjhvsdjhsdfvjzxjvxzhgshbdfg";//salt encryption logic will replace here 
        }


    }
}
