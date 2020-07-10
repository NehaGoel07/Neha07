using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TriviaGameLibraryShared;

namespace TriviaGameAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PlatformMasterController : ControllerBase
    {
        private readonly IPlatformMaster _platformMaster;
        public PlatformMasterController(IPlatformMaster platformMaster)
        {
            _platformMaster = platformMaster;
        }

        /// <summary>
        /// Fetching all platfrom 
        /// </summary>
        /// <returns>Task</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllPlatform()
        {
            try
            {
                List<PlatformMasterViewModel> platformMasters = await _platformMaster.GetAllPlatform();
                if (platformMasters == null)
                    return NoContent();
                else
                    return Ok(platformMasters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetching platform using Id
        /// </summary>
        /// <param name="platformId"></param>
        /// <returns>Task</returns>

        [HttpGet("{platformId}")]
        public async Task<IActionResult> GetDifficultyLevelById(int platformId)
        {
            try
            {
                PlatformMasterViewModel platformMaster = await _platformMaster.GetPlatformById(platformId);
                if (platformMaster == null)
                    return NoContent();
                else
                    return Ok(platformMaster);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Add new platform
        /// </summary>
        /// <param name="platformMasterViewModel"></param>
        /// <returns>Task</returns>

        [HttpPost]
        public async Task<IActionResult> AddNewPlatform(PlatformMasterViewModel platformMasterViewModel)
        {
            try
            {
                if (platformMasterViewModel == null)
                    return NoContent();
                else
                {
                    if (await _platformMaster.AddPlatform(platformMasterViewModel) > 0)
                    {
                        return Ok();
                    }
                    else
                        return NoContent();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Updating platform record
        /// </summary>
        /// <param name="platformId"></param>
        /// <param name="platform"></param>
        /// <returns>Task</returns>
        [HttpPut]
        public async Task<IActionResult> UpdatePlatform(int platformId, PlatformMasterViewModel platform)
        {
            try
            {
                if (platformId != platform.Id)
                    return BadRequest();
                else
                {
                    if (await _platformMaster.UpdatePlatform(platform) > 0)
                        return Ok();
                    else
                        return NoContent();
                }
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
        [HttpDelete]
        public async Task<IActionResult> DeletePlatform(int platformId)
        {
            try
            {
                if (await _platformMaster.DeletePlatform(platformId) > 0)
                    return Ok();
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}