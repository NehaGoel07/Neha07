using System;
using ProjectAPI.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ProjectAPI.Model.Repository.Class;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using ProjectAPI.Model.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace ProjectAPI.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    [ServiceFilter(typeof(MyActionFilter))]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _student;
        private readonly ILogger _logger;

        public StudentController(IStudent student,ILogger<StudentController> logger)
        {
            _student = student;
            _logger = logger;

        }

        ///GET:GetAllStudent
        /// <summary>
        /// Calling a service which returns data of all the students
        /// </summary>
        /// <returns>IActionResult</returns>

        [HttpGet]
        public IEnumerable<TblStudentDetails> GetAllStudent([FromQuery]PagingDetails paging)
        {
            try
            {
                var studentData = _student.GetStudentData(paging);
                if (studentData != null)
                    //HttpContext.Response.Headers.Add("Paging-Headers", JsonConvert.SerializeObject(pageData));
                    return studentData;

                else
                    return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Calling a service which returns single student data based on it's Id
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns>IActionResult</returns>
        
        [HttpGet("{studentId}")]
        public IActionResult GetStudentById(int studentId)
        {
                var singleStudentData = _student.GetSingleStudentData(studentId);
                if (singleStudentData == null)
                {
                    _logger.LogWarning("Student not found with id {id}",studentId);
                    return StatusCode(StatusCodes.Status204NoContent);
                }
                else
                    return Ok(singleStudentData);
        }

        ///GET:GetByName
        /// <summary>
        /// Calls the service to search the list of students by matching a string
        /// </summary>
        /// <param name="name"></param>
        /// <returns>IActionResult</returns>
        
        [HttpGet("{name}")]
        public IActionResult GetByString(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return StatusCode(StatusCodes.Status400BadRequest);
            else
            {
                var searchedData = _student.SearchingByString(name);
                if (searchedData == null)
                    return StatusCode(StatusCodes.Status204NoContent);
                else
                    return Ok(searchedData);
            }
        }

        /// GET:GetSpecificFields
        /// <summary>
        /// calls the service to get specified fields of student data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields"></param>
        /// <returns>IActionResult</returns>
        [HttpGet("{id}")]
        public IActionResult GetSpecificFields(int id,string fields=null)
        {
            var matchingData = _student.GetStudentDataFields(id, fields);
            return Ok(matchingData);

        }

        /// <summary>
        /// Calls the service to add a new student data
        /// </summary>
        /// <param name="studentDetails"></param>
        /// <returns>IActionResult</returns>
        [CustomExceptionFilter]
        [HttpPost]
        public async Task<IActionResult> PostNewStudent([ModelBinder(typeof(UpdateModelBinder))]TblStudentDetails studentDetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _student.AddStudentData(studentDetails) >= 0)
                        return Ok(studentDetails);
                    else
                        return BadRequest();
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                throw;
            }
        
        }

        /// <summary>
        /// Calls the service to edit current student data
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="studentDetails"></param>
        /// <returns>IActionResult</returns>

        [AllowAnonymous]
        [HttpPut("{studentId}")]
        public IActionResult UpdateStudentData(int studentId, TblStudentDetails studentDetails)
        {
            if (studentId != studentDetails.StudentId)
                throw new Exception();
            else
            {
                if (_student.UpdateDetails(studentDetails) >= 0)
                    return Ok();
                else
                    return NoContent();
            }
        }

        /// <summary>
        /// Calls the service to delete student data
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns>IActionResult</returns>

        [HttpDelete("{studentId}")]
        public IActionResult RemoveStudent(int studentId)
        {
            if (_student.RemoveStudentData(studentId) < 0)
                return BadRequest();
            else
                return Ok();
        }

    }
}