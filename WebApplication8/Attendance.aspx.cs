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
    public partial class MissingStudents : System.Web.UI.Page
    {

        DateTime whereDate;
        bool attend = false;
        string date;
        string selectedstud;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserID"] == null)
            {

                Response.Redirect("Login.aspx");

            //}
            if (ddlStudentName.Items.Count > 0)
            {

            }
            else
            {
                BusinessLogic.Student students = new BusinessLogic.Student();

                DataTable dt = students.getStudentNameDataTable();

                ddlStudentName.DataValueField = "FLD_STUDENTID";
                ddlStudentName.DataTextField = "Name";

                ddlStudentName.DataSource = dt;
                ddlStudentName.DataBind();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {            



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void calLessonDate_SelectionChanged(object sender, EventArgs e)
        {
            whereDate = calLessonDate.SelectedDate;

            date = whereDate.Date.ToString("yyyy/MM/dd");
            BusinessLogic.Lesson lessons = new BusinessLogic.Lesson();
            DataTable dtls = lessons.getLessonDescriptionDataTable(date);

            ddlLesson.DataValueField = "fld_LessonID";
            ddlLesson.DataTextField = "fld_Description";

            ddlLesson.DataSource = dtls;
            ddlLesson.DataBind();
        }

        protected void btnRecord_Click(object sender, EventArgs e)
        {
            BusinessLogic.Student thisstud = new BusinessLogic.Student();
            thisstud.getStudent((int.Parse(ddlStudentName.SelectedValue.ToString())));
            string success = "1";

            
            BusinessLogic.Attendance attendee = new BusinessLogic.Attendance(0, int.Parse(ddlLesson.SelectedValue.ToString()), int.Parse(ddlStudentName.SelectedValue), thisstud.GuardianId, calLessonDate.SelectedDate, attend);
                success = attendee.InsertToDatabase();
                Label1.Text = success;


            


            if (success == "")
            {
                success = "Attendance was succesfully logged";
                MessageBox.Show(this.Page, success);

            }
            else
            {
                MessageBox.Show(this.Page, "Failed to log Attendance");

            }

        }

        protected void ddlAttended_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAttended.SelectedValue == "0") {
                attend = false;
            }

            if (ddlAttended.SelectedValue == "1") {
                attend = true;
            }
        }

      
    }
}