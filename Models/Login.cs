using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace LoginAPI.Models
{
    public class Login
    {
        public int Id { get; set; }     
        public string loginType { get; set; }     
        public string username { get; set; }     
        public string emailId { get; set; }     
        public string password { get; set; }     
        public string lastPassword { get; set; }     
        public string isActive { get; set; }     
    }
}