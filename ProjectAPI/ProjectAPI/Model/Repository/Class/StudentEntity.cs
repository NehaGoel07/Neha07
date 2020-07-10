using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProjectAPI.Model.DataAccessLayer;
using ProjectAPI.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.Model.Repository.Class;


namespace ProjectAPI.Model.Repository.Class
{
    public class StudentEntity : IStudent
    {
        private readonly StudentContext _context;
        public StudentEntity(StudentContext context)
        {
            _context=context;
        }

        /// <summary>
        /// Fetching student data
        /// </summary>
        /// <returns>IEnumerable</returns>
        public List<TblStudentDetails> GetStudentData(PagingDetails paging)
        {
            var data = _context.TblStudentDetails.ToList();
            if (data == null)
                throw new DBCustomException("DB Exceptions");
            else
            {
                int countStudentData = data.Count;
                int currentPage = paging.pageNumber;
                int pageSize = paging.pageSize;
                int totalDataPagesCount = countStudentData;
                int totalDataPages = (int)Math.Ceiling(countStudentData / (double)pageSize);
                var studentPageData = data.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
                var prevPage = currentPage > 1 ? "Yes" : "No";
                var nextPage = currentPage < totalDataPages ? "Yes" : "No";
                var pageData = new
                {
                    totalCount = totalDataPagesCount,
                    pageSize = pageSize,
                    currentPage = currentPage,
                    totalPages = totalDataPages,
                    prevPage,
                    nextPage
                };
                return studentPageData;
                
            }
        }

        /// <summary>
        /// Fetching student data based on StudentId
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns>TblStudentDetails</returns>
        public TblStudentDetails GetSingleStudentData(int studentId)
        {
            var studentData = _context.TblStudentDetails.SingleOrDefault(x => x.StudentId == studentId);
            if (studentData != null)
                return studentData;
            else
                return null; ;
            //else
            //    throw new DBCustomException("DB Exceptions");
        }
        

        /// <summary>
        /// Add new student data
        /// </summary>
        /// <param name="student"></param>
        /// <returns>int</returns>
        public virtual async Task<int> AddStudentData(TblStudentDetails student)
        {
            _context.TblStudentDetails.Add(student);
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete student data
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns>int</returns>
        public virtual int RemoveStudentData(int studentId)
        {
            var studentData = _context.TblStudentDetails.FirstOrDefault(x => x.StudentId == studentId);
            _context.TblStudentDetails.Remove(studentData);
            _context.Entry(studentData).State = EntityState.Deleted;
            return _context.SaveChanges();
        }

        /// <summary>
        /// Updte the details of existing student
        /// </summary>
        /// <param name="studentDetails"></param>
        /// <returns>int</returns>
        public virtual int UpdateDetails(TblStudentDetails studentDetails)
        {
            var updatedData=_context.Update(studentDetails);
            return _context.SaveChanges();
        }

        /// <summary>
        /// Searching student through string passed 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>List</returns>
        public List<TblStudentDetails> SearchingByString(string name)
        {
            var searchedData = _context.TblStudentDetails
                .Where(x => x.StudentName.ToUpper().Contains(name.Trim().ToUpper()))
                .ToList();
            if (searchedData != null)
                return searchedData;
            else
                return null;
        }

        /// <summary>
        /// Fetch specific fields if provided from student data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields"></param>
        /// <returns>object</returns>
        public object GetStudentDataFields(int id, string fields)
        {
            var fieldList = new List<string>();
            if(fields!=null)
                fieldList = fields.Split(',').ToList();
            TblStudentDetails studentList = _context.TblStudentDetails.FirstOrDefault(x => x.StudentId == id);
            object filteredByFieldData = GetDataByField.FieldFilteredData(studentList, fieldList);
            return filteredByFieldData;
        }

    }
}
