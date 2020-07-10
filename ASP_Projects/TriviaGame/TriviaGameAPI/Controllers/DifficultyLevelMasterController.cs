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
    public class DifficultyLevelMasterController : ControllerBase
    {
        private readonly IDifficultyLevelMaster _difficultyLevelMaster;
        public DifficultyLevelMasterController(IDifficultyLevelMaster difficultyLevelMaster)
        {
            _difficultyLevelMaster = difficultyLevelMaster;
        }

        /// <summary>
        /// Fetching all difficulty level from DifficultyLevelMaster table
        /// </summary>
        /// <returns>Task</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllDifficultyLevel()
        {
            try
            {
                List<DifficultyLevelMasterViewModel> difficultyLevels = await _difficultyLevelMaster.GetAllDifficulty();
                if (difficultyLevels == null)
                    return NoContent();
                else
                    return Ok(difficultyLevels);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetching difficulty level using Id
        /// </summary>
        /// <param name="diffId"></param>
        /// <returns>Task</returns>

        [HttpGet("{diffId}")]
        public async Task<IActionResult> GetDifficultyLevelById(int diffId)
        {
            try
            {
                DifficultyLevelMasterViewModel difficultyLevels = await _difficultyLevelMaster.GetDifficultyLevelById(diffId);
                if (difficultyLevels == null)
                    return NoContent();
                else
                    return Ok(difficultyLevels);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Add new difficulty level
        /// </summary>
        /// <param name="difficultyLevelMasterViewModel"></param>
        /// <returns>Task</returns>

        [HttpPost]
        public async Task<IActionResult> AddNewDifficulty(DifficultyLevelMasterViewModel difficultyLevelMasterViewModel)
        {
            try
            {
                if (difficultyLevelMasterViewModel == null)
                    return NoContent();
                else
                {
                    if (await _difficultyLevelMaster.AddNewDifficultyLevel(difficultyLevelMasterViewModel) > 0)
                    {
                        return Ok();
                    }
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
        /// Updating difficulty level record
        /// </summary>
        /// <param name="diffId"></param>
        /// <param name="difficultyLevelMasterViewModel"></param>
        /// <returns>Task</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateDifficulty(int diffId,DifficultyLevelMasterViewModel difficultyLevelMasterViewModel)
        {
            try
            {
                if (diffId != difficultyLevelMasterViewModel.Id)
                    return BadRequest();
                else
                {
                    if (await _difficultyLevelMaster.UpdateDifficultyLevel(difficultyLevelMasterViewModel) > 0)
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
        /// Deleting difficulty level
        /// </summary>
        /// <param name="diffId"></param>
        /// <returns>Task</returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteDifficulty(int diffId)
        {
            try
            {
                if (await _difficultyLevelMaster.DeleteDifficultyLevel(diffId) > 0)
                    return Ok();
                else
                    return BadRequest();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}