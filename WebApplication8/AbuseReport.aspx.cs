using System;
using System.Data;
using WebApplication8.BusinessLogic;

namespace WebApplication8
{
    public partial class AbuseReport : System.Web.UI.Page
    {
        protected BusinessLogic.Student abusedStudent = new BusinessLogic.Student();

        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the user is logged in or not. kick them out if they are not
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            BusinessLogic.Student students = new BusinessLogic.Student();
            try
            {
                if (ddlStudentName.Items.Count > 0) { }
                else
                {
                    DataTable dt = students.getStudentNameDataTable();
                    ddlStudentName.DataValueField = "FLD_STUDENTID";
                    ddlStudentName.DataTextField = "Name";
                    ddlStudentName.DataSource = dt;
                    ddlStudentName.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            BusinessLogic.Student currentStudent = new BusinessLogic.Student();
            try
            {
                currentStudent.getStudent(int.Parse(ddlStudentName.SelectedValue.ToString()));
                BusinessLogic.AbuseReport abused = new BusinessLogic.AbuseReport(0, int.Parse(Session["userID"].ToString()), int.Parse(ddlStudentName.SelectedValue.ToString()), currentStudent.GuardianId, txtDescription.Text.ToString(), txtActionTaken.Text.ToString(), txtComment.Text, DateTime.Now);

                string success = abused.InsertToDatabase();

                if (success == "")
                {
                    success = "Abuse was succesfully logged";
                    MessageBox.Show(this.Page, success);
                    txtActionTaken.Text = "";
                    txtComment.Text = "";
                    txtDescription.Text = "";
                }
                else
                {
                    MessageBox.Show(this.Page, "Failed to log Abuse");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }
    }
}