using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2KOLKIT.Models
{
    public class AddToRole
    {
        public string UserEmail { get; set; }
        public List<string> Users { get; set; }
        public string selectedRole { get; set; }
        public List<string> roles { get; set; }
        public AddToRole()
        {
            roles = new List<string>();
            Users = new List<string>();
        }

    }
}