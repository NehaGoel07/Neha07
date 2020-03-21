using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFirst.Models
{
    public class TransactionContext : DbContext
    {
        public TransactionContext():base("connection")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<Products> Products { get; set; }
    }
}