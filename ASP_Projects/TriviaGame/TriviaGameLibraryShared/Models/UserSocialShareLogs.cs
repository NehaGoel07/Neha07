using System;
using System.Collections.Generic;

namespace TriviaGameLibraryShared
{
    public partial class UserSocialShareLogs
    {
        public int Id { get; set; }
        public string UsrCompKey { get; set; }
        public string ShareDetails { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Remarks { get; set; }
    }
}
