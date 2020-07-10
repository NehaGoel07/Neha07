using System;
using System.Collections.Generic;

namespace TriviaGameLibraryShared
{
    public partial class Questions
    {
        public Questions()
        {
            Answers = new HashSet<Answers>();
            UserQuestionLogs = new HashSet<UserQuestionLogs>();
        }

        public int QuesId { get; set; }
        public string QuesTitle { get; set; }
        public string QuesDesc { get; set; }
        public string QuesImage { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int FkDiffLvlId { get; set; }
        public int FkQuesTypeId { get; set; }
        public int FkAdmUserId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }

        public virtual AdminUsers FkAdmUser { get; set; }
        public virtual DifficultyLevelMaster FkDiffLvl { get; set; }
        public virtual QuestionTypeMaster FkQuesType { get; set; }
        public virtual ICollection<Answers> Answers { get; set; }
        public virtual ICollection<UserQuestionLogs> UserQuestionLogs { get; set; }
    }
}
