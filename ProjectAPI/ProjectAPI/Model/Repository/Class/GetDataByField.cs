using ProjectAPI.Model.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ProjectAPI.Model.Repository.Class
{
    public class GetDataByField
    {
        //Data Shaping
        public static object FieldFilteredData(TblStudentDetails studentDetails,List<string> fields)
        {
            if (fields.Count==0)
            {
                return studentDetails;
            }
            else
            {
                //creates an object whose members can be added or removed at run time
                ExpandoObject result = new ExpandoObject();

                foreach (var data in fields)
                {
                    var fieldValue = studentDetails.GetType()
                        .GetProperty(data,
                        BindingFlags.IgnoreCase |
                        BindingFlags.Public |
                        BindingFlags.Instance)
                        .GetValue(studentDetails, null);
                    ((IDictionary<String, object>)result).Add(data, fieldValue);
                    
                }
                return result;
            }
        }
    }
}
