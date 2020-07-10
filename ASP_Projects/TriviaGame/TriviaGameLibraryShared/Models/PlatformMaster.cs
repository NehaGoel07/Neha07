using System;
using System.Collections.Generic;

namespace TriviaGameLibraryShared
{
    public partial class PlatformMaster
    {
        public PlatformMaster()
        {
            Games = new HashSet<Games>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string PlatformType { get; set; }
        public string PlatformDesc { get; set; }
        public string PlatformCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Games> Games { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
