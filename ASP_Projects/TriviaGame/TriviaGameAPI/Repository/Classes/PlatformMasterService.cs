using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public class PlatformMasterService : IPlatformMaster
    {
        private readonly TriviaGameContext _triviaGame;
        public PlatformMasterService(TriviaGameContext triviaGame)
        {
            _triviaGame = triviaGame;
        }

        /// <summary>
        /// add new platform
        /// </summary>
        /// <param name="platformMasterViewModel"></param>
        /// <returns>Task</returns>
        public async Task<int> AddPlatform(PlatformMasterViewModel platformMasterViewModel)
        {
            try
            {
                PlatformMaster platformMaster = new PlatformMaster
                {
                    Id = platformMasterViewModel.Id,
                    PlatformCode = platformMasterViewModel.PlatformCode,
                    PlatformType = platformMasterViewModel.PlatformType.ToUpper(),
                    PlatformDesc = platformMasterViewModel.PlatformDesc
                };
                _triviaGame.Add(platformMaster);
                return await _triviaGame.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Deleting platform
        /// </summary>
        /// <param name="platformId"></param>
        /// <returns>Task</returns>
        public async Task<int> DeletePlatform(int platformId)
        {
            try
            {
                PlatformMaster platformMaster = await _triviaGame.PlatformMaster
                    .FirstOrDefaultAsync(x => x.Id == platformId && !x.IsDeleted && x.IsActive);
                if (platformMaster != null)
                {
                    platformMaster.IsActive = false;
                    platformMaster.IsDeleted = true;
                    _triviaGame.Entry(platformMaster).State = EntityState.Modified;
                    return await _triviaGame.SaveChangesAsync();
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// get all platform
        /// </summary>
        /// <returns>Task</returns>
        public async Task<List<PlatformMasterViewModel>> GetAllPlatform()
        {
            List<PlatformMasterViewModel> platformMasters = new List<PlatformMasterViewModel>();
            try
            {
                var platforms = _triviaGame.PlatformMaster.Where(x => x.IsActive && !x.IsDeleted);
                if (platforms == null)
                    return null;
                else
                {
                    foreach (var item in platforms)
                    {
                        PlatformMasterViewModel platformMasterViewModel = new PlatformMasterViewModel
                        {
                            Id = item.Id,
                            PlatformCode = item.PlatformCode,
                            PlatformDesc = item.PlatformDesc,
                            PlatformType = item.PlatformType
                        };
                        platformMasters.Add(platformMasterViewModel);
                    }
                    return platformMasters;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// fetch platform details using Id
        /// </summary>
        /// <param name="platformId"></param>
        /// <returns>Task</returns>
        public async Task<PlatformMasterViewModel> GetPlatformById(int platformId)
        {
            PlatformMaster platformMaster = new PlatformMaster();
            PlatformMasterViewModel platformMasterViewModel = new PlatformMasterViewModel();
            try
            {

                platformMaster = await _triviaGame.PlatformMaster.FirstOrDefaultAsync(x => x.Id == platformId);
                if (platformMaster != null)
                {
                    platformMasterViewModel.Id = platformMaster.Id;
                    platformMasterViewModel.PlatformCode = platformMaster.PlatformCode;
                    platformMasterViewModel.PlatformDesc = platformMaster.PlatformDesc;
                    platformMasterViewModel.PlatformType = platformMaster.PlatformType;
                    return platformMasterViewModel;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// updating platform details
        /// </summary>
        /// <param name="platform"></param>
        /// <returns>Task</returns>
        public async Task<int> UpdatePlatform(PlatformMasterViewModel platform)
        {
            try
            {
                PlatformMaster platformMaster = await _triviaGame.PlatformMaster
                    .FirstOrDefaultAsync(x => x.Id == platform.Id && !x.IsDeleted && x.IsActive);
                if (platformMaster != null)
                {
                    platformMaster.PlatformType = platform.PlatformType.ToUpper();
                    platformMaster.PlatformCode = platform.PlatformCode;
                    platformMaster.PlatformDesc = platform.PlatformDesc;
                    _triviaGame.Entry(platformMaster).State = EntityState.Modified;
                    return await _triviaGame.SaveChangesAsync();
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
