using EntityFrameworkCodeFirst.Models;
using EntityFrameworkCodeFirst.Repository;
using EntityFrameworkCodeFirst.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EntityFrameworkCodeFirst.Controllers
{
    
    public class CodeFirstController : ApiController
    {
        private ISales _sales;
        //TransactionContext context = new TransactionContext();
        public CodeFirstController(Sales sales)
        {
            _sales = sales;
        }

        /// Get:Show/Display
        /// <summary>
        /// Show calls a method which displays all the customer details with their order details
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpGet]
        public IHttpActionResult Show()
        {
            try
            {
                var data = _sales.Display();
                return Ok(data);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        ///Get:ShowSingle/DisplayId
        /// <summary>
        /// ShowSingle calls a method which displays the details of specific customer it's corresponding order and product details
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IHttpActionResult</returns>
        [HttpGet]
        public IHttpActionResult ShowSingle(int id)
        {
            try
            {
                var data = _sales.DisplayId(id);
                return Ok(data);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// Post:AddData/NewRecord
        /// <summary>
        /// NewRecord calls a method which adds new data 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpPost]
        public IHttpActionResult AddData(Orders orders)
        {
            try
            {
                var data = _sales.NewRecord(orders);
                return Ok(data);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// Put:Update/AddNew
        /// <summary>
        /// Update calls a method which adds a new order for an existing customer
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpPut]
        public IHttpActionResult Update(Orders orders)
        {
            try
            {
                var data = _sales.AddNew(orders);
                return Ok(data);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        ///Delete:Delete/RemoveEntry
        /// <summary>
        /// Delete calls a method which deletes a record from all three tables
        /// </summary>
        /// <param name="orders"></param>
        /// <returns>bool</returns>
        [HttpDelete]
        public IHttpActionResult Delete(Orders orders)
        {
            try
            {
                var del = _sales.RemoveEntry(orders);
                return Ok(del);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
