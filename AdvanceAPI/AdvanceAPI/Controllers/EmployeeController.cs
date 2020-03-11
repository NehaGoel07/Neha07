using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AdvanceAPI.Data;
using AdvanceAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceAPI.Controllers
{
    [Route("api/[controller]/{Action}")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployees _employees;
        public EmployeeController(IEmployees employees)
        {
            _employees = employees;
        }
        public IActionResult Show()
        {
            DataSet ds = _employees.Disp();
            return Ok(ds);
        }

        [HttpPost]
        public ActionResult<bool> InsertEmp(EmployeesCRUD empInsert)
        {
            var result = _employees.InsertEmp(empInsert);
            return Ok(result);
        }

        //using overloaded HttpGet which accepts an ID from URL
        [HttpGet("{id}")]
        public IActionResult ShowSingle(int id)
        {
            DataSet dataSet = _employees.SingleData(id);
            return Ok(dataSet);
        }

        [HttpPut]
        public bool UpdateEmp(EmployeesCRUD empUpdate)
        {
            var updated = _employees.UpdateData(empUpdate);
            return updated;
        }

        [HttpDelete]
        public bool DelEmp(EmployeesCRUD empDelete)
        {
            var deleted = _employees.DeleteData(empDelete);
            return deleted;
        }
    }
}