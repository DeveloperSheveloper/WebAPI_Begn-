using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string loginType { get; set; }
        public string username { get; set; }
        public string emailId { get; set; }
        public string password { get; set; }
        public string lastPassword { get; set; }
    }
}