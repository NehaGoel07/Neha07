using DBFirstEntity.Models;
using DBFirstEntity.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBFirstEntity.Services
{
    public class CRUD : ICRUD
    {
        /// <summary>
        /// AddNew method adds new record in the Orders table along with customer and product details
        /// </summary>
        /// <param name="orders"></param>
        public void AddNew(Orders orders)
        {

            var db_context = new SalesContext();
            try
            {
                db_context.Orders.Add(orders);
                db_context.Customer.Add(orders.FkCust);
                db_context.Products.Add(orders.FkProd);
                db_context.SaveChanges();
            }
            catch(DbUpdateException ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Delete method removes a record of a customer,it's corresponding order and the product purchased
        /// </summary>
        /// <param name="orders"></param>
        public void Delete(Orders orders)
        {
            var db_context = new SalesContext();
            try
            {
                var o = db_context.Customer.First(d => d.CustId == orders.FkCustId);
                db_context.Customer.Remove(o);
                var c = db_context.Orders.First(d => d.OrderId == orders.OrderId);
                db_context.Orders.Remove(c);
                var p = db_context.Products.First(d => d.ProdId == orders.FkProdId);
                db_context.Products.Remove(p);
                db_context.SaveChanges();
            }
            catch(DbUpdateException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// NewOrder method adds a new order for the existing customer
        /// </summary>
        /// <param name="orders"></param>
        public void NewOrder(Orders orders)
        {
            var db_context = new SalesContext();
            try
            {
                db_context.Orders.Add(orders);
                db_context.SaveChanges();
            }
            catch(DbUpdateException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ShowAll method displays all the customer data along with their order details
        /// </summary>
        /// <returns>List</returns>
        public List<Customer> ShowAll()
        {
            var db_context = new SalesContext();
            try
            {
                var data = db_context.Customer.Include("Orders").ToList();
                return data;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ShowById displays the details of a particular customer,order corresponding to the customer and he details of the product purchased
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List</returns>
        public List<Customer> ShowById(int id)
        {
            var db_context = new SalesContext();
            try
            {
                var data = db_context.Customer.Where(c => c.CustId == id).Include(o => o.Orders).ThenInclude(p => p.FkProd).ToList();
                return data;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
