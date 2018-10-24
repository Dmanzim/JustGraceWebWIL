using System;
using WebApplication8.BusinessLogic;


namespace WebApplication8
{
    public partial class Tester : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //clear the username when the user logs out
            Session["UserID"] = null;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Log the user into the system
            BusinessLogic.Employee currentEmployee = new BusinessLogic.Employee();

            currentEmployee.Email = txtUserName.Text;
            currentEmployee.Password = txtPassword.Text;
            try
            {
                bool loggedin = currentEmployee.loginEmployee();

                if (loggedin)
                {
                    Session["UserID"] = currentEmployee.ID;
                    Response.Redirect("RegisterLesson.aspx");
                }
                else
                {
                    MessageBox.Show(this, "Username and password do not match, try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }
    }
}