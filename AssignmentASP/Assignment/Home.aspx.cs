using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome " + Session["UserName"]);

            Response.Write("<br/>No of applications: " + Application["RunningApps"]);
            Response.Write("<br/>Total users at the moment: " + Application["UsersPresent"]);
        }
    }
}