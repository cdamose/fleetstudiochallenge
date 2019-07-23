using System;
using System.Collections.Generic;

namespace MovieAPI.DBContext
{
    public partial class UsersToken
    {
        public string UserId { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime AcessTokenCreatedDate { get; set; }
        public decimal AccessTokenLifeTime { get; set; }
        public DateTime RefreshTokenCretaedDate { get; set; }
        public decimal RefreshTokenLifeTime { get; set; }
    }
}
