using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public interface IDifficultyLevelMaster
    {
        Task<List<DifficultyLevelMasterViewModel>> GetAllDifficulty();
        Task<DifficultyLevelMasterViewModel> GetDifficultyLevelById(int diffId);
        Task<int> AddNewDifficultyLevel(DifficultyLevelMasterViewModel difficultyLevelMasterViewModel);

        Task<int> UpdateDifficultyLevel(DifficultyLevelMasterViewModel difficulty);
        Task<int> DeleteDifficultyLevel(int diffId);
    }
}
