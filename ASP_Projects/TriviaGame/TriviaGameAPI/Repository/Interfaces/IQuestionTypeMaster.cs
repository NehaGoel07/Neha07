using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public interface IQuestionTypeMaster
    {
        Task<List<QuestionTypeMasterViewModel>> GetAllQuestionType();
        Task<QuestionTypeMasterViewModel> GetQuestionTypeById(int quesId);
        Task<int> AddNewQuestionType(QuestionTypeMasterViewModel questionTypeMasterViewModel);

        Task<int> UpdateQuesType(QuestionTypeMasterViewModel questionType);
        Task<int> DeleteQuestionType(int quesId);
    }
}
