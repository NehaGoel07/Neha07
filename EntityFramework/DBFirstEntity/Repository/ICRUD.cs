using DBFirstEntity.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBFirstEntity.Repository
{
    public interface ICRUD
    {
        public List<Customer> ShowAll();

        public List<Customer> ShowById(int id);

        public void AddNew(Orders orders);

        public void Delete(Orders orders);

        public void NewOrder(Orders orders);
    }
}
