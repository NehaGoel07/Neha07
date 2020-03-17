using System;
using System.Collections.Generic;

namespace TokenImplement.Models
{
    public partial class Login
    {

        /// <summary>
        /// DBFirst -- Login Table fields
        /// </summary>
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string Roles { get; set; }
    }
}
