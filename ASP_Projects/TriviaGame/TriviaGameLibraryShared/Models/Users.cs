using System;
using System.Collections.Generic;

namespace TriviaGameLibraryShared
{
    public partial class Users
    {
        public Users()
        {
            UserQuestionLogs = new HashSet<UserQuestionLogs>();
        }

        public int Id { get; set; }
        public string UsrName { get; set; }
        public string UsrEmail { get; set; }
        public int? UsrDob { get; set; }
        public int? UsrZipCode { get; set; }
        public long? UsrPhone { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int FkGameId { get; set; }
        public int FkDiffLvlId { get; set; }
        public int FkPlatformId { get; set; }
        public int TotalScore { get; set; }
        public int TotalTime { get; set; }
        public int NoOfQuesAttempt { get; set; }
        public DateTime GameSdt { get; set; }
        public DateTime GameEdt { get; set; }
        public string UsrCompKey { get; set; }
        public string Remarks { get; set; }

        public virtual DifficultyLevelMaster FkDiffLvl { get; set; }
        public virtual Games FkGame { get; set; }
        public virtual PlatformMaster FkPlatform { get; set; }
        public virtual ICollection<UserQuestionLogs> UserQuestionLogs { get; set; }
    }
}
