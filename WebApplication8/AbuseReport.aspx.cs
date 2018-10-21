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
    public partial class AbuseReport : System.Web.UI.Page
    {
        protected BusinessLogic.Student abusedStudent = new BusinessLogic.Student();

        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["UserID"] == null)
            //{

            //    Response.Redirect("Login.aspx");

            //}


            BusinessLogic.Student students = new BusinessLogic.Student();

            DataTable dt = students.getStudentNameDataTable();

            ddlStudentName.DataValueField = "FLD_STUDENTID";
            ddlStudentName.DataTextField = "Name";

            ddlStudentName.DataSource = dt;
            ddlStudentName.DataBind();

            

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            BusinessLogic.Student currentStudent = new BusinessLogic.Student();
            currentStudent.getStudent(int.Parse(ddlStudentName.SelectedValue.ToString()));

            

            BusinessLogic.AbuseReport abused = new BusinessLogic.AbuseReport(0, int.Parse(Session["userID"].ToString()), int.Parse(ddlStudentName.SelectedValue.ToString()), currentStudent.GuardianId, txtDescription.Text.ToString(), txtActionTaken.Text.ToString(), txtComment.Text, DateTime.Now);

            string success = abused.InsertToDatabase();
            
            
            if (success == "")
            {
                success = "Abuse was succesfully logged";
                MessageBox.Show(this.Page , success);

                txtActionTaken.Text = "";
                txtComment.Text = "";
                txtDescription.Text = "";
            }
            else
            {
                MessageBox.Show(this.Page, "Failed to log Abuse");
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void ddlStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}