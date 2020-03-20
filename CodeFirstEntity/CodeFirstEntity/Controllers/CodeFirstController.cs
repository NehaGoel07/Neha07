using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstEntity.Models;
using CodeFirstEntity.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstEntity.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class CodeFirstController : ControllerBase
    {
        private readonly IEndpoints _endpoints;
        public CodeFirstController(IEndpoints endpoints)
        {
            _endpoints = endpoints;
        }

        /// Get:DisplayAll/Show
        /// <summary>
        /// DisplayAll calls a method which displays all the customer details with their order details
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult DisplayAll()
        {
            try
            {
                var data = _endpoints.Show();
                return Ok(data);
            }
            catch
            {
                return Ok();
            }
        }

        /// Get:DisplaySingle/ShowSingle
        /// <summary>
        /// DisplaySingle calls a method which displays the details of specific customer it's corresponding order and product details
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id}")]
        public IActionResult DisplaySingle(int id)
        {
            try
            {
                var res = _endpoints.ShowSingle(id);
                return Ok(res);
            }
            catch
            {
                return Ok();
            }
        }

        /// Post:InsertNew/NewRecord
        /// <summary>
        /// InsertNew calls a method which adds new data 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpPost]
        public IActionResult InsertNew(Orders orders)
        {
            try
            {
                var result=_endpoints.NewRecord(orders);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// Put:AddOrder/NewOrder
        /// <summary>
        /// AddOrder calls a method which adds a new order for an existing customer
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpPut]
        public IActionResult AddOrder(Orders orders)
        {
            try
            {
                var result=_endpoints.NewOrder(orders);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// Delete:Delete/RemoveRecord
        /// <summary>
        /// Delete calls a method which deletes a record from all three tables
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpDelete]
        public IActionResult Delete(Orders orders)
        {
            try
            {
                var result=_endpoints.RemoveRecord(orders);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}