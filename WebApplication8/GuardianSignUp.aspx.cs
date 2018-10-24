using System;
using WebApplication8.BusinessLogic;

namespace WebApplication8
{
    public partial class GuardianSignUp : System.Web.UI.Page
    {
        back.SQLConnect sqlConn;
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the user is logged in or not. kick them out if they are not
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            sqlConn = new back.SQLConnect();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Save guardian to the databse
            try
            {
                Guardian Guard = new Guardian(0, txtFirstName.Text, txtSurname.Text, txtContactNo.Text, txtEmail.Text, txtAddress.Text, true, txtPassword.Text);
                if (!Guard.InsertToDatabase().Equals(""))
                {
                    lblRegisterSuccess.Text = "Error";
                    MessageBox.Show(this.Page, "Failed to save Guardian to Database.");
                }
                else
                {
                    txtAddress.Text = "";
                    txtContactNo.Text = "";
                    txtEmail.Text = "";
                    txtFirstName.Text = "";
                    txtPassword.Text = "";
                    txtSurname.Text = "";
                    MessageBox.Show(this.Page, "Guardian Saved to Database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }
    }
}