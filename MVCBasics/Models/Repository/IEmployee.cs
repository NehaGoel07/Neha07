using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBasics.Models.Repository
{
    interface IEmployee
    {
        List<TBL_Employees> Data();

        bool EditData(TBL_Employees tBL_Employees);
    }
}
