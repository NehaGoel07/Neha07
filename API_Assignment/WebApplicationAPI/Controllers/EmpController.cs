using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using WebApplicationAPI.Data;
using WebApplicationAPI.Models;
using System.Data;

namespace WebApplicationAPI.Controllers
{
    public class EmpController : ApiController
    {
        Class1 Class1 = new Class1();

        //show all the data from the table
        [HttpGet]
        public IHttpActionResult Show()
        {
            DataSet ds = Class1.Disp();
            return Ok(ds);
        }

        //insert a new record in the table
        [HttpPost]
        public bool InsertEmp(Employees emp1)
        {
            var result = Class1.InsertEmp(emp1);
            return result;
        }

        //retrieving single row from the table
        [HttpPost]
        public IHttpActionResult ShowSingle(Employees empName)
        {
            DataSet dataSet = Class1.SingleData(empName);
            return Ok(dataSet);
        }

        //updating data in the table
        [HttpPut]
        public bool UpdateEmp(Employees empUpdate)
        {
            var updated = Class1.UpdateData(empUpdate);
            return updated;
        }

        //deleting a record from the table
        [HttpDelete]
        public bool DelEmp(Employees empDelete)
        {
            var deleted = Class1.DeleteData(empDelete);
            return deleted;
        }
    }
}
