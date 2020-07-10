using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGameLibraryShared
{
    public class RoleMaster
    {
        public int Id { get; set; }

        public string RoleType { get; set; }

        public string RoleDesc { get; set; }

        public string RoleCode { get; set; }
        
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<AdminUsers> AdminUsers { get; set; }
    }
}
