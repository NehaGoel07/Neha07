using ProjectAPI.Model.DataAccessLayer;
using ProjectAPI.Model.Repository.Class;
using ProjectAPI.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model.Repository
{
    public interface IStudent
    {
        List<TblStudentDetails> GetStudentData(PagingDetails paging);

        TblStudentDetails GetSingleStudentData(int studentId);

        object GetStudentDataFields(int id, string fields);

        List<TblStudentDetails> SearchingByString(string name);

        Task<int> AddStudentData(TblStudentDetails student);

        int RemoveStudentData(int studentId);

        int UpdateDetails(TblStudentDetails studentDetails);

    }
}
