using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication8.BusinessLogic;

namespace WebApplication8
{
    public partial class Registration : System.Web.UI.Page
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

            //Check id the drop down is empty and fill it if it is
            if (ddlGuardian.DataValueField.Count() > 0) { }
            else
            {
                //Get data table of the guardians and fill the drop down list
                BusinessLogic.Guardian guardian = new BusinessLogic.Guardian();
                try
                {
                    DataTable dt = guardian.getGuardianDropDownDataTable();
                    ddlGuardian.DataValueField = "ID";
                    ddlGuardian.DataTextField = "Name";
                    ddlGuardian.DataSource = dt;
                    ddlGuardian.DataBind();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, "Failed to get database information. Error :" + ex);
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Create object of the student class for the new student
            BusinessLogic.Student newStudent = new BusinessLogic.Student(0, int.Parse(ddlGuardian.SelectedValue), txtFirstName.Text, txtSurname.Text, txtPassword.Text, true, txtEmail.Text);
            try { 
                //Insert the student into the DB
                String result = newStudent.InsertToDatabase();
                //Check if the insert into the db was a success
                if (result == "")
                {
                    MessageBox.Show(this.Page, "Successfully saved Student");
                    txtEmail.Text = "";
                    txtFirstName.Text = "";
                    txtPassword.Text = "";
                    txtSurname.Text = "";
                }
                else
                {
                    MessageBox.Show(this.Page, "Error occurred : " + result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
            
        }

        
    }
}