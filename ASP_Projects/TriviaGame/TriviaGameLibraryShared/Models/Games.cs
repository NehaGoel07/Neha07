using System;
using System.Collections.Generic;

namespace TriviaGameLibraryShared
{
    public partial class Games
    {
        public Games()
        {
            GameRules = new HashSet<GameRules>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string GameTitle { get; set; }
        public string GameDesc { get; set; }
        public string GameImage { get; set; }
        public int? QuesCount { get; set; }
        public int? MaxScore { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int FkPlateformId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string GameName { get; set; }
        public int GameId { get; set; }
        public int? GameStartDate { get; set; }
        public int? GameEndDate { get; set; }

        public virtual PlatformMaster FkPlateform { get; set; }
        public virtual ICollection<GameRules> GameRules { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
