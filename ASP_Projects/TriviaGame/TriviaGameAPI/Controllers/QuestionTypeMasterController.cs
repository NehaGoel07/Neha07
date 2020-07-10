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
    public class QuestionTypeMasterController : ControllerBase
    {
        private readonly IQuestionTypeMaster _questionTypeMaster;
        public QuestionTypeMasterController(IQuestionTypeMaster questionTypeMaster)
        {
            _questionTypeMaster = questionTypeMaster;
        }

        /// <summary>
        /// Fetching all question type
        /// </summary>
        /// <returns>Task</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllQuestionType()
        {
            try
            {
                List<QuestionTypeMasterViewModel> questionTypeMasters = await _questionTypeMaster.GetAllQuestionType();
                if (questionTypeMasters == null)
                    return NoContent();
                else
                    return Ok(questionTypeMasters);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetching question type using Id
        /// </summary>
        /// <param name="quesId"></param>
        /// <returns>Task</returns>

        [HttpGet("{quesId}")]
        public async Task<IActionResult> GetQuestionTypeById(int quesId)
        {
            try
            {
                QuestionTypeMasterViewModel questionTypeMasters = await _questionTypeMaster.GetQuestionTypeById(quesId);
                if (questionTypeMasters == null)
                    return NoContent();
                else
                    return Ok(questionTypeMasters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Add new question type
        /// </summary>
        /// <param name="typeMasterViewModel"></param>
        /// <returns>Task</returns>

        [HttpPost]
        public async Task<IActionResult> AddNewQuestionType(QuestionTypeMasterViewModel typeMasterViewModel)
        {
            try
            {
                if (typeMasterViewModel == null)
                    return NoContent();
                else
                {
                    if (await _questionTypeMaster.AddNewQuestionType(typeMasterViewModel) > 0)
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
        /// Updating question  type record
        /// </summary>
        /// <param name="quesId"></param>
        /// <param name="questionTypeMaster"></param>
        /// <returns>Task</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateQuestionType(int quesId, QuestionTypeMasterViewModel questionTypeMaster)
        {
            try
            {
                if (quesId != questionTypeMaster.Id)
                    return BadRequest();
                else
                {
                    if (await _questionTypeMaster.UpdateQuesType(questionTypeMaster) > 0)
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
        /// Delete question type record
        /// </summary>
        /// <param name="quesId"></param>
        /// <returns>Task</returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteType(int quesId)
        {
            try
            {
                if (await _questionTypeMaster.DeleteQuestionType(quesId) > 0)
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