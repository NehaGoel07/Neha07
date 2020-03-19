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

        /// <summary>
        /// InsertNew calls a method which adds new data 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpPost]
        public bool InsertNew(Orders orders)
        {
            try
            {
                _endpoints.NewRecord(orders);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// AddOrder calls a method which adds a new order for an existing customer
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpPut]
        public bool AddOrder(Orders orders)
        {
            try
            {
                _endpoints.NewOrder(orders);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete calls a method which deletes a record from all three tables
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpDelete]
        public bool Delete(Orders orders)
        {
            try
            {
                _endpoints.RemoveRecord(orders);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}