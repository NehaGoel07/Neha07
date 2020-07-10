using System;
using System.Collections.Generic;

namespace TriviaGameLibraryShared
{
    public partial class GameRuleDesc
    {
        public int Id { get; set; }
        public int FkGameRuleId { get; set; }
        public int FkDifficultyLvlId { get; set; }
        public int NoOfQues { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Remarks { get; set; }

        public virtual DifficultyLevelMaster FkDifficultyLvl { get; set; }
        public virtual GameRules FkGameRule { get; set; }
    }
}
