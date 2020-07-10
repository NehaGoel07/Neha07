using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public class DifficultyLevelMasterService : IDifficultyLevelMaster
    {
        private readonly TriviaGameContext _triviaGame;
        public DifficultyLevelMasterService(TriviaGameContext triviaGame)
        {
            _triviaGame = triviaGame;
        }

        /// <summary>
        /// Adding new difficulty level
        /// </summary>
        /// <param name="difficultyLevelMasterViewModel"></param>
        /// <returns>Task</returns>
        public async Task<int> AddNewDifficultyLevel(DifficultyLevelMasterViewModel difficultyLevelMasterViewModel)
        {
            try
            {
                DifficultyLevelMaster difficultyLevelMaster = new DifficultyLevelMaster
                {
                    Id = difficultyLevelMasterViewModel.Id,
                    DiffCode = difficultyLevelMasterViewModel.DiffCode,
                    DiffLvl = difficultyLevelMasterViewModel.DiffLvl.ToUpper(),
                    Weightage = difficultyLevelMasterViewModel.Weightage
                };
                _triviaGame.Add(difficultyLevelMaster);
                return await _triviaGame.SaveChangesAsync();
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Deleting difficulty level record
        /// </summary>
        /// <param name="diffId"></param>
        /// <returns>Task</returns>
        public async Task<int> DeleteDifficultyLevel(int diffId)
        {
            try
            {
                DifficultyLevelMaster difficultyLevel = await _triviaGame.DifficultyLevelMaster
                    .FirstOrDefaultAsync(x => x.Id == diffId && !x.IsDeleted && x.IsActive);
                if (difficultyLevel != null)
                {
                    difficultyLevel.IsActive = false;
                    difficultyLevel.IsDeleted = true;
                    _triviaGame.Entry(difficultyLevel).State = EntityState.Modified;
                    return await _triviaGame.SaveChangesAsync();
                }
                else
                    return 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetching difficulty level on the basis of Id
        /// </summary>
        /// <param name="diffId"></param>
        /// <returns>Task</returns>
        public async Task<DifficultyLevelMasterViewModel> GetDifficultyLevelById(int diffId)
        {
            DifficultyLevelMaster difficultyLevelMaster = new DifficultyLevelMaster();
            DifficultyLevelMasterViewModel difficultyLevelMasterViewModel = new DifficultyLevelMasterViewModel();
            try
            {

                difficultyLevelMaster = await _triviaGame.DifficultyLevelMaster.FirstOrDefaultAsync(x => x.Id == diffId);
                if (difficultyLevelMaster != null)
                {
                    difficultyLevelMasterViewModel.Id = difficultyLevelMaster.Id;
                    difficultyLevelMasterViewModel.DiffCode = difficultyLevelMaster.DiffCode;
                    difficultyLevelMasterViewModel.DiffLvl = difficultyLevelMaster.DiffLvl;
                    difficultyLevelMasterViewModel.Weightage = difficultyLevelMaster.Weightage;
                    return difficultyLevelMasterViewModel;
                }
                else
                    return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetching all difficulty levels
        /// </summary>
        /// <returns>Task</returns>
        public async Task<List<DifficultyLevelMasterViewModel>> GetAllDifficulty()
        {
            List<DifficultyLevelMasterViewModel> difficultyLevels = new List<DifficultyLevelMasterViewModel>();
            try
            {
                var difficulty =  _triviaGame.DifficultyLevelMaster.Where(x => x.IsActive && !x.IsDeleted);
                if (difficulty == null)
                    return null;
                else
                {
                    foreach(var item in difficulty)
                    {
                        DifficultyLevelMasterViewModel difficultyLevelMasterViewModel = new DifficultyLevelMasterViewModel
                        {
                            Id = item.Id,
                            DiffCode = item.DiffCode,
                            DiffLvl = item.DiffLvl,
                            Weightage = item.Weightage
                        };
                        difficultyLevels.Add(difficultyLevelMasterViewModel);
                    }
                    return difficultyLevels;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// updating existing difficulty level record
        /// </summary>
        /// <param name="difficulty"></param>
        /// <returns>Task</returns>
        public async Task<int> UpdateDifficultyLevel(DifficultyLevelMasterViewModel difficulty)
        {
            try
            {
                DifficultyLevelMaster difficultyLevelMaster = await _triviaGame.DifficultyLevelMaster
                    .FirstOrDefaultAsync(x => x.Id == difficulty.Id && !x.IsDeleted && x.IsActive);
                if(difficultyLevelMaster!=null)
                {
                    difficultyLevelMaster.Weightage = difficulty.Weightage;
                    difficultyLevelMaster.DiffCode = difficulty.DiffCode;
                    difficultyLevelMaster.DiffLvl = difficulty.DiffLvl.ToUpper();
                    _triviaGame.Entry(difficultyLevelMaster).State = EntityState.Modified;
                    return await _triviaGame.SaveChangesAsync();
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
