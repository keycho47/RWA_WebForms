using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RWA_Labos.Repo
{
    public class User
    {
        public int IDUser { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public User()
        {     
            
        }

    }
}