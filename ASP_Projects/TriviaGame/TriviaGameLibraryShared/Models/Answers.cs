using System;
using System.Collections.Generic;

namespace TriviaGameLibraryShared
{
    public partial class Answers
    {
        
        public int AnsId { get; set; }
        public int FkQuesId { get; set; }
        public string Answer { get; set; }
        public bool AnsType { get; set; }
        public string AnswerExplanation { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Questions FkQues { get; set; }
        public virtual ICollection<UserQuestionLogs> UserQuestionLogs { get; set; }
    }
}
