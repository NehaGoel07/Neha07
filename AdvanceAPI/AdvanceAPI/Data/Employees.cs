using AdvanceAPI.Model;
using AdvanceAPI.Models;
using Microsoft.AspNet.SignalR.Infrastructure;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceAPI.Data
{
    public class Employees : IEmployees
    {
        private readonly IOptions<ConnectionString> _connection;
        public Employees(IOptions<ConnectionString> connection)
        {
            _connection = connection;
        }

        //Displaying all the data from the table
        public DataSet Disp()
        {
            try
            {
                string con = _connection.Value.connectionStr;
                SqlConnection sqlConnection = new SqlConnection(con);
                SqlCommand command = new SqlCommand("select * from TBL_Employees", sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        //Inserting new row or data in the table
        public bool InsertEmp(EmployeesCRUD empCRUD)
        {
            try
            {
                string con = _connection.Value.connectionStr;
                SqlConnection sqlConnection = new SqlConnection(con);
                //using stored procedure to insert a record
                SqlCommand cmd = new SqlCommand("usp_InsertEmp @emp_name,@emp_dob,@emp_salary,@manager_id,@IsTrainer", sqlConnection);
                cmd.Parameters.AddWithValue("@emp_name", empCRUD.Emp_name);
                cmd.Parameters.AddWithValue("@emp_dob", empCRUD.Emp_dob);
                cmd.Parameters.AddWithValue("@emp_salary", empCRUD.Emp_salary);
                cmd.Parameters.AddWithValue("@manager_id", empCRUD.Manager_id);
                cmd.Parameters.AddWithValue("@IsTrainer", empCRUD.IsTrainer);
                sqlConnection.Open();
                int res = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                if (res >= 0)
                    return true;
                else
                    return false;

            }
            catch (SqlException)
            {
                return false;
            }
        }

        //Retreiving single row from the table 
        public DataSet SingleData(int id)
        {
            try
            {
                string con = _connection.Value.connectionStr;
                SqlConnection sqlConnection = new SqlConnection(con);
                //retrieving data by passing an ID
                SqlCommand cmd = new SqlCommand("select * from TBL_Employees where emp_id=@Emp_id", sqlConnection);
                cmd.Parameters.AddWithValue("@Emp_id", id);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        //updating salary of an employee by specifying employee name
        public bool UpdateData(EmployeesCRUD empData)
        {
            try
            {
                string con = _connection.Value.connectionStr;
                SqlConnection sqlConnection = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("update TBL_Employees set emp_salary=@Emp_salary where emp_name=@Emp_name ", sqlConnection);
                cmd.Parameters.AddWithValue("@emp_name", empData.Emp_name);
                cmd.Parameters.AddWithValue("@emp_salary", empData.Emp_salary);
                sqlConnection.Open();
                int updatedDat = cmd.ExecuteNonQuery();
                sqlConnection.Close();
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

        //deleting a row by passing employee name
        public bool DeleteData(EmployeesCRUD empDel)
        {
            try
            {
                string con = _connection.Value.connectionStr;
                SqlConnection sqlConnection = new SqlConnection(con);
                //using stored procedure to delete a record
                SqlCommand cmd = new SqlCommand("usp_deleteRecord @emp_name", sqlConnection);
                cmd.Parameters.AddWithValue("@emp_name", empDel.Emp_name);
                sqlConnection.Open();
                int delDat = cmd.ExecuteNonQuery();
                sqlConnection.Close();
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
