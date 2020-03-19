using CodeFirstEntity.Models;
using CodeFirstEntity.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEntity.Services
{
    public class Endpoints : IEndpoints
    {

        /// <summary>
        /// Show method displays all the customer data along with their order details
        /// </summary>
        /// <returns>List</returns>
        public List<Customer> Show()
        {
            var db_context = new TransactionContext();
            try
            {
                var data = db_context.Customers.Include("Orders").ToList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ShowSingle displays the details of a particular customer,order corresponding to the customer and he details of the product purchased
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List</returns>
        public List<Customer> ShowSingle(int id)
        {
            var db_context = new TransactionContext();
            try
            {
                var data = db_context.Customers.Where(c => c.CustId == id).Include(o => o.Orders).ThenInclude(p => p.FkProd).ToList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// NewRecord method adds new record in the Orders table along with customer and product details
        /// </summary>
        /// <param name="orders"></param>
        public void NewRecord(Orders orders)
        {
            var db_context = new TransactionContext();
            try
            {

                db_context.Orders.Add(orders);
                db_context.Customers.Add(orders.FkCust);
                db_context.Products.Add(orders.FkProd);
                db_context.SaveChanges();
            }
            catch (DbUpdateException ex)
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
            var db_context = new TransactionContext();
            try
            {
                db_context.Orders.Add(orders);
                db_context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// RemoveRecord method removes a record of a customer,it's corresponding order and the product purchased
        /// </summary>
        /// <param name="orders"></param>
        public void RemoveRecord(Orders orders)
        {
            var db_context = new TransactionContext();
            try
            {
                var o = db_context.Customers.First(d => d.CustId == orders.FkCustId);
                db_context.Customers.Remove(o);
                var c = db_context.Orders.First(d => d.OrderId == orders.OrderId);
                db_context.Orders.Remove(c);
                var p = db_context.Products.First(d => d.ProdId == orders.FkProdId);
                db_context.Products.Remove(p);
                db_context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
        }
    }
}
