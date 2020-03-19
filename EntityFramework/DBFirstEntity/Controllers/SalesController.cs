using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBFirstEntity.Models;
using DBFirstEntity.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstEntity.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ICRUD _iCRUD;
        public SalesController(ICRUD iCRUD)
        {
            _iCRUD = iCRUD;
        }


        /// <summary>
        /// GetAllData calls a method which displays all the customer details with their order details
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult GetAllData()
        {
            try
            {
                var Data = _iCRUD.ShowAll();
                return Ok(Data);
            }
            catch
            {
                return Ok();
            }
        }

        /// <summary>
        /// GetSingle calls a method which displays the details of specific customer it's corresponding order and product details
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IActionResult</returns>
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            try
            {
                var res = _iCRUD.ShowById(id);
                return Ok(res);
            }
            catch
            {
                return Ok();
            }
        }

        /// <summary>
        /// Insert calls a method which adds new data 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpPost]
        public bool Insert(Orders orders)
        {
            try
            {
                _iCRUD.AddNew(orders);
                return true;
            }
            catch
            {
                return false;
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
                _iCRUD.NewOrder(orders);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Remove calls a method which deletes a record from all three tables
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpDelete]
        public bool Remove(Orders orders)
        {
            try
            {
                _iCRUD.Delete(orders);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}