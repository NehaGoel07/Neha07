using System;
using System.Collections.Generic;

namespace BreadCrumb.Entity
{
    public partial class Login
    {
        public int LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
