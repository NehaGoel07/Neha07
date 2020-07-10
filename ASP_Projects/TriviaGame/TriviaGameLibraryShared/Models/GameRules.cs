using System;
using System.Collections.Generic;

namespace TriviaGameLibraryShared
{
    public partial class GameRules
    {
        public GameRules()
        {
            GameRuleDesc = new HashSet<GameRuleDesc>();
        }

        public int Id { get; set; }
        public int FkGameId { get; set; }
        public int FkDifficultyLvlId { get; set; }
        public int NoOfQues { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Remarks { get; set; }

        public virtual DifficultyLevelMaster FkDifficultyLvl { get; set; }
        public virtual Games FkGame { get; set; }
        public virtual ICollection<GameRuleDesc> GameRuleDesc { get; set; }
    }
}
