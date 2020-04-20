using BlazorAssignment.Repository;
using BlazorAssignmentClassLibrary.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorAssignment.Services
{
    public class Student : IStudent
    {
        private readonly HttpClient _httpClient;

        public Student(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Calling API Post Method to add a record
        /// </summary>
        /// <param name="studentDetails"></param>
        /// <returns>bool</returns>
        public bool AddStudent(TblStudentDetails studentDetails)
        {
            _httpClient.SendJsonAsync(HttpMethod.Post, "https://localhost:44357/api/Student/PostStudent", studentDetails);
            return true;
            
        }

        /// <summary>
        /// Calling API to get data of a particular student
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>TblStudentDetails</returns>
        public TblStudentDetails GetStudentById(string Id)
        {
            int id = Convert.ToInt32(Id);
            var studentDetails =  _httpClient.GetStringAsync("https://localhost:44357/api/Student/GetStudent/" + id);
            return JsonConvert.DeserializeObject<TblStudentDetails>(studentDetails.Result);
        }

        /// <summary>
        /// Calling API to edit the data 
        /// </summary>
        /// <param name="studentDetails"></param>
        /// <returns>bool</returns>
        public  bool EditDetails(TblStudentDetails studentDetails)
        {

            var res =  _httpClient.SendJsonAsync(HttpMethod.Put, "https://localhost:44357/api/Student/PutStudent", studentDetails);
            return true; 
        }

        /// <summary>
        /// Calling API to get data of all students
        /// </summary>
        /// <returns>IEnumerable</returns>
        public IEnumerable<TblStudentDetails> GetStudentData()
        {
            var result=  _httpClient.GetStringAsync("https://localhost:44357/api/Student/GetStudent");
            return JsonConvert.DeserializeObject<List<TblStudentDetails>>(result.Result);
        }
    }
}
