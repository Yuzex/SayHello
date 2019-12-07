using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SayHello.Models
{
    public class HelloUsers
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
    }
}