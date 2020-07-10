using ProjectAPI.Model.DataAccessLayer;
using ProjectAPI.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Model.Repository.Class;

namespace ProjectAPI.Model.Service
{
    public class Student : StudentEntity
    {
        private readonly StudentContext _context;
        public Student(StudentContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Add a new entry of student
        /// </summary>
        /// <param name="student"></param>
        /// <returns>bool</returns>

        public override async Task<int> AddStudentData(TblStudentDetails student)
        {
                var addData = await _context.Database.ExecuteSqlRawAsync("usp_StudentInsert @studentName,@Course,@Address,@Email,@Gender",
                    new SqlParameter("studentName", student.StudentName),
                    new SqlParameter("Course", student.Course),
                    new SqlParameter("Address", student.Address),
                    new SqlParameter("Email", student.Email),
                    new SqlParameter("Gender", student.Gender));
            if (addData.Equals(0))
                throw new DBCustomException("DB Exceptions");
            else
                return addData;

        }


        /// <summary>
        /// Remove a record of student
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns>int</returns>

        public override int RemoveStudentData(int studentId)
        {
            var removeData = _context.Database.ExecuteSqlRaw("exec usp_DeleteStudent @studentId",new SqlParameter("studentId", studentId));
            if (removeData.Equals(0))
                throw new DBCustomException("DB Exceptions");
            else
                return removeData;
        }

        /// <summary>
        /// updates the data of existing student
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="studentDetails"></param>
        /// <returns>int</returns>
        
        public override int UpdateDetails(TblStudentDetails studentDetails)
        {
                var updateData = _context.Database.ExecuteSqlRaw("usp_StudentUpdate @studentId,@studentName,@Course,@Address,@Email,@Gender={5}",
                    new SqlParameter("studentId",studentDetails.StudentId),
                    new SqlParameter("studentName",studentDetails.StudentName),
                    new SqlParameter("Course",studentDetails.Course),
                    new SqlParameter("Address",studentDetails.Address),
                    new SqlParameter("Email",studentDetails.Email),
                    new SqlParameter("Gender",studentDetails.Gender)
                    );
                if (updateData.Equals(0))
                    throw new DBCustomException("DB Exceptions");
                else
                    return updateData;
        }

    }
}
