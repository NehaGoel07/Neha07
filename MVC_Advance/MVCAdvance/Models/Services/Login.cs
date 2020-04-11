using MVCAdvance.Models.Entity;
using MVCAdvance.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAdvance.Models.Services
{
    public class Login:ILogin
    {
        /// <summary>
        /// checking login credentials
        /// </summary>
        /// <param name="loginDetail"></param>
        /// <returns>bool</returns>
        public bool AuthenticateCreds(LoginDetail loginDetail)
        {
            try
            {
                conn conn = new conn();
                var name = conn.LoginDetails.Where(x => x.Username == loginDetail.Username).Select(x => x.Username).ToList();
                var password = conn.LoginDetails.Where(x => x.Password == loginDetail.Password).Select(x => x.Password).ToList();
                if (loginDetail.Username == name.FirstOrDefault() && loginDetail.Password == password.FirstOrDefault())
                {

                    return true; ;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetching employees data
        /// </summary>
        /// <returns>List</returns>
        public List<TBL_Employees> ShowData()
        {
            try
            {
                conn conn = new conn();
                var data = conn.TBL_Employees.ToList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetching Employee data from database
        /// </summary>
        /// <returns>List</returns>
        public List<Employee> Show()
        {
            try
            {
                conn conn = new conn();
                var data = conn.Employees.ToList();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Fetching data of single employee using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Employee</returns>

        public Employee Detail(int id)
        {
            try
            {

                var context = new conn();
                var data = context.Employees.Where(x => x.emp_id == id).FirstOrDefault();
                return data;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            

        }


    }
}