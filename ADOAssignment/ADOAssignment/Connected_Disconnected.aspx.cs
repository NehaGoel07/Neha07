using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ADOAssignment
{
    public partial class Connected_Disconnected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ConnectedBtn_Click(object sender, EventArgs e)
        {
            //Connected architecture
            Label1.Visible = true;
            Label1.Text = "Showing Data using Connected Architecture</br>";
            Label2.Visible = false;
            //Handling connection with the help of try catch block
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from ButtonEvent", conn);
                
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                conn.Close();
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine("Error: " + sqlex);
            }
            
        }

        protected void DisconnectedBtn_Click(object sender, EventArgs e)
        {
            //checking if cache contains some value or is currently empty
            if (Cache["FormData_Data"] == null)
            {
                Label2.Visible = true;
                Label2.Text = "Fetching data from database";
                //Disconnected architecture
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                Label1.Visible = true;
                Label1.Text = "Showing Data using Disconnected Architecture</br>";
                //Handling connection with the help of "using" which will automatically handle the connection
                string ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("select * from formData", connection);
                    connection.Open();
                    cmd.CommandType = CommandType.Text;
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    //Binding cache with the data set having data fetched from database
                    Cache["FormData_Data"] = ds;
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                }
            }
            else
            {
                Label2.Visible = true;
                Label2.Text = "Fetching data from cache";
                //Binding gridview with the cache having data stored from database
                GridView1.DataSource = (DataSet)Cache["FormData_Data"];
                GridView1.DataBind();
            }

        }
    }
}