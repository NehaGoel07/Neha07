
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public interface IRoleMaster
    {
        Task<List<RoleMasterViewModel>> GetRoles();

        Task<RoleMasterViewModel> GetRoleById(int roleId);

        Task<int> AddNewRole(RoleMasterViewModel roleMaster);
        Task<int> DeleteRole(int roleId);

        Task<RoleMaster> UpdateRoleMaster(RoleMasterViewModel roleMaster);
    }
}
