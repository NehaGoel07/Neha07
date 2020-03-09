using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Http;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Data
{
    public class Class1
    {
        
        
        string ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        
        //Displaying all the data from the records
        public DataSet Disp()
        {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("select * from TBL_Employees", connection);
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }            
        }
       
        //Insering new record in the table
        public bool InsertEmp(Employees emp1)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                //using stored procedure to insert a record
                SqlCommand cmd = new SqlCommand("usp_InsertEmp @emp_name,@emp_dob,@emp_salary,@manager_id,@IsTrainer", connection);
                cmd.Parameters.AddWithValue("@emp_name",emp1.Emp_name);
                cmd.Parameters.AddWithValue("@emp_dob", emp1.Emp_dob);
                cmd.Parameters.AddWithValue("@emp_salary", emp1.Emp_salary);
                cmd.Parameters.AddWithValue("@manager_id", emp1.Manager_id);
                cmd.Parameters.AddWithValue("@IsTrainer", emp1.IsTrainer);
                connection.Open();
                int res = cmd.ExecuteNonQuery();
                connection.Close();
                if (res >= 0)
                    return true;
                else
                    return false;

            }
            catch(Exception ex)
            {
                return false;
            }
           
        }

        //Displaying single record from the table using where condition
        public DataSet SingleData(Employees empName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from TBL_Employees where emp_name=@Emp_name", connection);
                cmd.Parameters.AddWithValue("@emp_name", empName.Emp_name);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        //Update a record in the table
        public bool UpdateData(Employees empData)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("update TBL_Employees set emp_salary=@Emp_salary where emp_name=@Emp_name ", connection);
                cmd.Parameters.AddWithValue("@emp_name", empData.Emp_name);
                cmd.Parameters.AddWithValue("@emp_salary", empData.Emp_salary);
                connection.Open();
                int updatedDat = cmd.ExecuteNonQuery();
                connection.Close();
                if (updatedDat >= 0)
                    return true;
                else
                    return false;
            }
            catch(SqlException)
            {
                return false;
            }
        }

        //Delete a record from the table
        public bool DeleteData(Employees empDel)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                //using stored procedure to delete a record
                SqlCommand cmd = new SqlCommand("usp_deleteRecord @emp_name", connection);
                cmd.Parameters.AddWithValue("@emp_name", empDel.Emp_name);
                connection.Open();
                int delDat = cmd.ExecuteNonQuery();
                connection.Close();
                if (delDat >= 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}