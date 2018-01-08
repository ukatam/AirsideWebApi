using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASMWebAPI.Models
{
    public class RegisterLoginUser
    {
        public string username { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public  string lastname { get; set; }
        public string emailid { get; set; }
        public int profileoptionRadio { get; set; }
    }
}