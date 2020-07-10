using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public interface IPlatformMaster
    {
        Task<List<PlatformMasterViewModel>> GetAllPlatform();
        Task<PlatformMasterViewModel> GetPlatformById(int platformId);
        Task<int> AddPlatform(PlatformMasterViewModel platformMasterViewModel);

        Task<int> UpdatePlatform(PlatformMasterViewModel platform);
        Task<int> DeletePlatform(int platformId);
    }
}
