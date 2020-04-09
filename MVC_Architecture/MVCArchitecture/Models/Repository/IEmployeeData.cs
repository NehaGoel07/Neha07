using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCArchitecture.Models.EntityModel;

namespace MVCArchitecture.Models.Repository
{
    interface IEmployeeData
    {
        List<TBL_Employees> Data();
    }
}
