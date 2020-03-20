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

        public bool AddNew(Orders orders);

        public bool Delete(Orders orders);

        public bool NewOrder(Orders orders);
    }
}
