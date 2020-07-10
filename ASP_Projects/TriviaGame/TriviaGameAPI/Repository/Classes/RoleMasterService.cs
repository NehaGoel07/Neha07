using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaGameAPI;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public class RoleMasterService : IRoleMaster
    {
        private readonly TriviaGameContext _triviaGameContext;
        public RoleMasterService(TriviaGameContext triviaGameContext)
        {
            _triviaGameContext = triviaGameContext;
        }

        public Task<int> AddNewRole(RoleMasterViewModel roleMaster)
        {
            try
            {
                RoleMaster roleMasterData = new RoleMaster
                {
                    Id = roleMaster.Id,
                    RoleCode = roleMaster.RoleCode,
                    RoleDesc = roleMaster.RoleDesc,
                    RoleType = roleMaster.RoleType.ToUpper()
                };
                _triviaGameContext.AddAsync(roleMasterData);
                return _triviaGameContext.SaveChangesAsync();
                

            }
            catch(DbUpdateException ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteRole(int roleId)
        {
            try
            {
                RoleMaster roleMaster = await _triviaGameContext.RoleMaster.Where(x => x.Id == roleId).FirstOrDefaultAsync();
                if (roleMaster != null)
                {
                    roleMaster.IsDeleted = true;
                    roleMaster.IsActive = false;
                    _triviaGameContext.Entry(roleMaster).State = EntityState.Modified;
                    return await _triviaGameContext.SaveChangesAsync();
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

        public async Task<RoleMasterViewModel> GetRoleById(int roleId)
        {
            RoleMasterViewModel roleMasterViewModel = new RoleMasterViewModel();
            try
            {
                RoleMaster RoleData = await _triviaGameContext.RoleMaster.FirstOrDefaultAsync(x => x.Id == roleId && !x.IsDeleted && x.IsActive);
                if(RoleData==null)
                    return null;
                else
                {
                    roleMasterViewModel.RoleCode = RoleData.RoleCode;
                    roleMasterViewModel.Id = RoleData.Id;
                    roleMasterViewModel.RoleDesc = RoleData.RoleDesc;
                    roleMasterViewModel.RoleType = RoleData.RoleType.ToUpper();
                    return roleMasterViewModel;
                }
                 
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<RoleMasterViewModel>> GetRoles()
        {
            List<RoleMasterViewModel> roleMastersList = new List<RoleMasterViewModel>();
            try
            {

                var roles = await _triviaGameContext.RoleMaster.Where(x => x.IsActive && !x.IsDeleted).ToListAsync();

                if (roles == null)
                    return null;
                else
                {
                    foreach (var item in roles)
                    {
                        RoleMasterViewModel roleMasterView = new RoleMasterViewModel()
                        {
                            Id = item.Id,
                            RoleCode = item.RoleCode,
                            RoleDesc = item.RoleDesc,
                            RoleType = item.RoleType

                        };
                        roleMastersList.Add(roleMasterView);

                    }
                    return roleMastersList;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        public async Task<RoleMaster> UpdateRoleMaster(RoleMasterViewModel roleMaster)
        {
            try
            {
                RoleMaster updateRole = await _triviaGameContext.RoleMaster.Where(x => x.Id == roleMaster.Id).FirstOrDefaultAsync();
                if (updateRole != null)
                {
                    updateRole.RoleCode = roleMaster.RoleCode;
                    updateRole.RoleDesc = roleMaster.RoleDesc;
                    updateRole.RoleType = roleMaster.RoleType.ToUpper();
                    await _triviaGameContext.SaveChangesAsync();
                    _triviaGameContext.Entry(updateRole).State = EntityState.Modified;
                    return updateRole;
                }
                else 
                {
                    return updateRole;
                }
            }
            catch(DbUpdateException ex)
            {
                throw ex;
            }

                

                
        }
    }
}
