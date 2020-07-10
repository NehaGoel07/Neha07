using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public class QuestionTypeMasterService : IQuestionTypeMaster
    {
        private readonly TriviaGameContext _triviaGame;
        public QuestionTypeMasterService(TriviaGameContext triviaGame)
        {
            _triviaGame = triviaGame;
        }

        /// <summary>
        /// Add new Question Type
        /// </summary>
        /// <param name="questionTypeMasterViewModel"></param>
        /// <returns>Task</returns>
        public async Task<int> AddNewQuestionType(QuestionTypeMasterViewModel questionTypeMasterViewModel)
        {
            try
            {
                QuestionTypeMaster questionTypeMaster = new QuestionTypeMaster
                {
                    Id = questionTypeMasterViewModel.Id,
                    QuesCode = questionTypeMasterViewModel.QuesCode,
                    QuesType = questionTypeMasterViewModel.QuesType.ToUpper(),
                    Description = questionTypeMasterViewModel.Description
                };
                _triviaGame.Add(questionTypeMaster);
                return await _triviaGame.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete question type
        /// </summary>
        /// <param name="quesId"></param>
        /// <returns>Task</returns>
        public async Task<int> DeleteQuestionType(int quesId)
        {
            try
            {
                QuestionTypeMaster questionTypeMaster = await _triviaGame.QuestionTypeMaster
                    .FirstOrDefaultAsync(x => x.Id == quesId && !x.IsDeleted && x.IsActive);
                if (questionTypeMaster != null)
                {
                    questionTypeMaster.IsActive = false;
                    questionTypeMaster.IsDeleted = true;
                    _triviaGame.Entry(questionTypeMaster).State = EntityState.Modified;
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
        /// Fetch all the question type
        /// </summary>
        /// <returns>Task</returns>

        public async Task<List<QuestionTypeMasterViewModel>> GetAllQuestionType()
        {
            List<QuestionTypeMasterViewModel> questionTypes = new List<QuestionTypeMasterViewModel>();
            try
            {
                var questions = _triviaGame.QuestionTypeMaster.Where(x => x.IsActive && !x.IsDeleted);
                if (questions == null)
                    return null;
                else
                {
                    foreach (var item in questions)
                    {
                        QuestionTypeMasterViewModel questionTypeMasterViewModel = new QuestionTypeMasterViewModel
                        {
                            Id = item.Id,
                             Description=item.Description,
                             QuesCode=item.QuesCode,
                              QuesType=item.QuesType
                        };
                        questionTypes.Add(questionTypeMasterViewModel);
                    }
                    return questionTypes;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetching question type by Id
        /// </summary>
        /// <param name="quesId"></param>
        /// <returns>Task</returns>
        public async Task<QuestionTypeMasterViewModel> GetQuestionTypeById(int quesId)
        {
            QuestionTypeMaster questionTypeMaster = new QuestionTypeMaster();
            QuestionTypeMasterViewModel questionTypeMasterViewModel = new QuestionTypeMasterViewModel();
            try
            {

                questionTypeMaster = await _triviaGame.QuestionTypeMaster.FirstOrDefaultAsync(x => x.Id == quesId);
                if (questionTypeMaster != null)
                {
                    questionTypeMasterViewModel.Id = questionTypeMaster.Id;
                    questionTypeMasterViewModel.QuesType = questionTypeMaster.QuesType;
                    questionTypeMasterViewModel.QuesCode = questionTypeMaster.QuesCode;
                    questionTypeMasterViewModel.Description = questionTypeMaster.Description;
                    return questionTypeMasterViewModel;
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
        /// Updating existing record
        /// </summary>
        /// <param name="questionType"></param>
        /// <returns>Task</returns>
        public async Task<int> UpdateQuesType(QuestionTypeMasterViewModel questionType)
        {
            try
            {
                QuestionTypeMaster questionTypeMaster = await _triviaGame.QuestionTypeMaster
                    .FirstOrDefaultAsync(x => x.Id == questionType.Id && !x.IsDeleted && x.IsActive);
                if (questionTypeMaster != null)
                {
                    questionTypeMaster.QuesType = questionType.QuesType.ToUpper();
                    questionTypeMaster.QuesCode = questionType.QuesCode;
                    questionTypeMaster.Description = questionType.Description;
                    _triviaGame.Entry(questionTypeMaster).State = EntityState.Modified;
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
