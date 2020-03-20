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


        /// Get:GetAllData/ShowAll
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

        ///Get:GetSingle/ShowById
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

        /// Post:Insert/AddNew
        /// <summary>
        /// Insert calls a method which adds new data 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpPost]
        public IActionResult Insert(Orders orders)
        {
            try
            {
                var result=_iCRUD.AddNew(orders);
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
                var result=_iCRUD.NewOrder(orders);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        ///Delete:Remove/Delete
        /// <summary>
        /// Remove calls a method which deletes a record from all three tables
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpDelete]
        public IActionResult Remove(Orders orders)
        {
            try
            {
                var result=_iCRUD.Delete(orders);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}