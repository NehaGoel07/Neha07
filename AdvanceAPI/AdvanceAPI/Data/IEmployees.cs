using AdvanceAPI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceAPI.Data
{
    //interface to implement dependency injection
    public interface IEmployees
    {
        DataSet Disp();
        bool InsertEmp(EmployeesCRUD emp1);
        DataSet SingleData(int id);
        bool UpdateData(EmployeesCRUD empData);
        bool DeleteData(EmployeesCRUD empDel);

    }
}
