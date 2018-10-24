using System;
using System.Data;
using System.Linq;
using WebApplication8.BusinessLogic;

namespace WebApplication8
{
    public partial class RegisterEmployee : System.Web.UI.Page
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

            if (ddlEmployeeType.DataValueField.Count() > 0) { }
            else
            {
                Employee ddlemp = new Employee();
                try
                {
                    DataTable dt = ddlemp.getEmployeeTypeDataTable();
                    ddlEmployeeType.DataValueField = "ID";
                    ddlEmployeeType.DataTextField = "Name";
                    ddlEmployeeType.DataSource = dt;
                    ddlEmployeeType.DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Failed to get database information. Error :" + ex);
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //save new employee to the database 
            Employee newEmp = new Employee(0, txtFirstName.Text, txtLastName.Text, txtContactNumber.Text, txtEmailAddress.Text, txtPassword.Text, true, int.Parse(ddlEmployeeType.SelectedValue));
            try
            {
                String result = newEmp.InsertToDatabase();
                if (result == "")
                {
                    MessageBox.Show(this, "Employee saved successfully.");
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtContactNumber.Text = "";
                    txtEmailAddress.Text = "";
                    txtPassword.Text = "";
                }
                else
                {
                    MessageBox.Show(this, "Failed to save new employee. Error : " + result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }
    }
}