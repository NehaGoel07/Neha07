using BlazorAssignmentClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.Repository
{
    public interface IStudent
    {
        IEnumerable<TblStudentDetails> GetStudentData();

        bool EditDetails(TblStudentDetails studentDetails);

        bool AddStudent(TblStudentDetails studentDetails);

        TblStudentDetails GetStudentById(string Id);
    }
}
