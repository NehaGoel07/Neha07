using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGameLibraryShared
{
    public class DifficultyLevelMaster
    {
        public int Id { get; set; }
        public string DiffLvl { get; set; }
        public int Weightage { get; set; }
        public string DiffCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<GameRuleDesc> GameRuleDesc { get; set; }
        public virtual ICollection<GameRules> GameRules { get; set; }
        public virtual ICollection<Questions> Questions { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
