using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication8
{
    public partial class Tester : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void btnRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            BusinessLogic.Employee currentEmployee = new BusinessLogic.Employee();

            currentEmployee.Email = txtUserName.Text;
            currentEmployee.Password = txtPassword.Text;

            bool loggedin = currentEmployee.loginEmployee();

            if (loggedin)
            {
                Session["UserID"] = currentEmployee.ID;
                Response.Redirect("Index.aspx");
            }
            else
            {
                lblErrorMessage.Text = ("Username and password do not match, try again");
                lblErrorMessage.Visible = true;
            }



        }
    }
}