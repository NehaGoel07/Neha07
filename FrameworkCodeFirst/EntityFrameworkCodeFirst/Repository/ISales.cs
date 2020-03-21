using EntityFrameworkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFirst.Repository
{
    public interface ISales
    {
        List<Customer> Display();
        List<Customer> DisplayId(int id);

        bool NewRecord(Orders orders);

        bool AddNew(Orders orders);

        bool RemoveEntry(Orders orders);
    }
}