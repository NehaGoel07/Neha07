using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGameLibraryShared
{
    public class DifficultyLevelMasterViewModel
    {
        public int Id { get; set; }
        public string DiffLvl { get; set; }
        public int Weightage { get; set; }
        public string DiffCode { get; set; }
    }
}
