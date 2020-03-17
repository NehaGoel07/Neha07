using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TokenImplement.Models;

namespace TokenImplement.Data
{
    public class StudentInformation : IStudentInformation
    {

        /// <summary>
        /// Retreiving student data
        /// </summary>
        /// <returns>List</returns>
        public List<Login> GetData()
        {
            try
            {
                var context = new TokenContext();
                var data = (from l in context.Login
                            select l).ToList();
                return data;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retreiving only user data and not of admin
        /// </summary>
        /// <returns>List</returns>
        public List<Login> GetUData()
        {
            try
            {
                var context = new TokenContext();
                var info = (from l in context.Login
                            where l.Roles=="user"
                            select l).ToList();
                return info;
                            
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
