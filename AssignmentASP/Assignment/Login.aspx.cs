using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["UserName"] = TextBox1.Text;
            }
            //else
            //{
            //    if (Session["UserName"].ToString() == TextBox1.Text)
            //    {

            //        TextBox2.Text = ViewState["Password"].ToString();
            //    }
            //}
        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["UserName"] = TextBox1.Text;
            ViewState["Password"] = TextBox2.Text;
            Response.Redirect("Home.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                ViewState["Password"] = TextBox2.Text;
                TextBox2.Text = ViewState["Password"].ToString();

            }
        }
    }
}