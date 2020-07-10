using System;
using System.Collections.Generic;

namespace TriviaGameLibraryShared
{
    public partial class QuestionTypeMaster
    {
        public QuestionTypeMaster()
        {
            Questions = new HashSet<Questions>();
        }

        public int Id { get; set; }
        public string QuesType { get; set; }
        public string Description { get; set; }
        public string QuesCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Questions> Questions { get; set; }
    }
}
