using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGameLibraryShared
{
    public class AdminUsers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Token { get; set; }
        public DateTime TokenModifiedOn { get; set; }
        public int FK_RoleMasterId { get; set; }
        public RoleMaster RoleMaster { get; set; }

        public virtual ICollection<Questions> Questions { get; set; }
    }
}
