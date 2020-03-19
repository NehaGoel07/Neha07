using CodeFirstEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEntity.Repository
{
    public interface IEndpoints
    {
        public List<Customer> Show();

        public List<Customer> ShowSingle(int id);

        public void NewRecord(Orders orders);

        public void NewOrder(Orders orders);

        public void RemoveRecord(Orders orders);
    }
}
