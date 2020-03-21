using EntityFrameworkCodeFirst.Models;
using EntityFrameworkCodeFirst.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFirst.Services
{
    public class Sales:ISales
    {
        Models.TransactionContext context = new Models.TransactionContext();

        /// <summary>
        /// Display method displays all the customer data along with their order details
        /// </summary>
        /// <returns>List</returns>
        public List<Customer> Display()
        {
            try
            {
                var res = context.Customers.Include("Orders").ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// DisplayId displays the details of a particular customer,order corresponding to the customer and he details of the product purchased
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List</returns>
        public List<Customer> DisplayId(int id)
        {
            try
            {
                var result = (context.Customers.Include(o => o.Orders.Select(p => p.FkProd).Select(ords => ords.Orders)).Where(c => c.CustId == id)).ToList();
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// NewRecord method adds new record in the Orders table along with customer and product details
        /// </summary>
        /// <param name="orders"></param>
        public bool NewRecord(Orders orders)
        {
            try
            {
                context.Orders.Add(orders);
                context.Customers.Add(orders.FkCust);
                context.Products.Add(orders.FkProd);
                var success = context.SaveChanges();
                if (success > 0)
                    return true;
                else
                    return false;
            }
            catch(DbUpdateException ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// AddNew method adds a new order for the existing customer
        /// </summary>
        /// <param name="orders"></param>
        public bool AddNew(Orders orders)
        {
            try
            {
                context.Orders.Add(orders);
                var custId = context.Orders.Count(o => o.CustId == orders.CustId);
                var no = custId + 1;
                Customer c = context.Customers.FirstOrDefault(p => p.CustId == orders.CustId);
                c.NoOfOrders = no;
                var res = context.SaveChanges();
                if (res > 0)
                    return true;
                else
                    return false;
            }
            catch(DbUpdateException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// RemoveEntry method removes a record of a customer,it's corresponding order and the product purchased
        /// </summary>
        /// <param name="orders"></param>
        public bool RemoveEntry(Orders orders)
        {
            try
            {
                var o = context.Customers.First(d => d.CustId == orders.CustId);
                context.Customers.Remove(o);
                var c = context.Orders.First(d => d.OrderId == orders.OrderId);
                context.Orders.Remove(c);
                var p = context.Products.First(d => d.ProdId == orders.ProdId);
                context.Products.Remove(p);
                var res = context.SaveChanges();
                if (res > 0)
                    return true;
                else
                    return false;
            }
            catch(DbUpdateException ex)
            {
                throw ex;
            }
        }
    }
}