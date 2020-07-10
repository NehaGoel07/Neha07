using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class RoleMasterController : ControllerBase
    {
        private readonly IRoleMaster _roleMaster;
        public RoleMasterController(IRoleMaster roleMaster)
        {
            _roleMaster = roleMaster;
        }

        /// <summary>
        /// Fetching all the Roles data
        /// </summary>
        /// <returns>Task</returns>
        
        [Authorize(Roles ="ADMIN")]
        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            try
            {
                List<RoleMasterViewModel> listOfRoles = await _roleMaster.GetRoles();
                if (listOfRoles != null)
                    return Ok(listOfRoles);
                else
                    return NoContent();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetching single data
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns>Task</returns>

        [Authorize(Roles = "ADMIN")]
        [HttpGet("{roleId}")]
        
        public async Task<IActionResult> GetRoleById(int roleId)
        {
            try
            {
                RoleMasterViewModel RoleById = await _roleMaster.GetRoleById(roleId);
                if (RoleById == null)
                    return NoContent();
                else
                    return Ok(RoleById);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Adding a new record of Role in RoleMaster table
        /// </summary>
        /// <param name="roleMaster"></param>
        /// <returns>Task</returns>
        
        [Authorize(Roles ="SUPER")]
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleMasterViewModel roleMaster)
        {
            try
            {
                if (roleMaster == null)
                    return BadRequest();
                else
                {
                    if (await _roleMaster.AddNewRole(roleMaster) > 0)
                        return Ok();
                    else
                        return NoContent();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Removing a record 
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns>Task</returns>
        
        [Authorize(Roles = "SUPER")]
        [HttpDelete]
        public async Task<IActionResult> RemoveRole(int RoleId)
        {
            try
            {
                if (await _roleMaster.DeleteRole(RoleId) < 0)
                    return BadRequest();
                else
                    return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Updating an existing record
        /// </summary>
        /// <param name="masterViewModel"></param>
        /// <returns>Task</returns>

        
        [Authorize(Roles = "SUPER")]
        [HttpPut]
        public  async Task<ActionResult<RoleMaster>>  UpdateRole(RoleMasterViewModel masterViewModel)
        {
            try
            {
                if (masterViewModel == null)
                    return NoContent();
                else
                {
                    var updatedRole = await _roleMaster.UpdateRoleMaster(masterViewModel);
                    if ( updatedRole!=null)
                        return Ok(updatedRole);
                    else
                        return BadRequest();
                }
                

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}