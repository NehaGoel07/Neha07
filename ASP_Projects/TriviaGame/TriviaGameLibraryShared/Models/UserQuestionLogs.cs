using System;
using System.Collections.Generic;

namespace TriviaGameLibraryShared
{
    public partial class UserQuestionLogs
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int TotalTime { get; set; }
        public DateTime QuesSdt { get; set; }
        public DateTime QuesEdt { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int FkUsrId { get; set; }
        public int FkQuesId { get; set; }
        public int FkAnsId { get; set; }
        public string Remarks { get; set; }

        public virtual Answers FkAns { get; set; }
        public virtual Questions FkQues { get; set; }
        public virtual Users FkUsr { get; set; }
    }
}
