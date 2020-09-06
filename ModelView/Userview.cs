using projectnetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectnetwork.ModelView
{
    public class Userview
    {

        public Login Login_Use { get; set; }

        public List<Login> Logins { get; set; }

        public Admin student { get; set; }
    }
}