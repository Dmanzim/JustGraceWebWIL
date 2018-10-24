using System;
using System.Data;
using WebApplication8.BusinessLogic;

namespace WebApplication8
{
    public partial class MissingStudents : System.Web.UI.Page
    {
        DateTime whereDate;
        bool attend = false;
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the user is logged in or not. kick them out if they are not
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (ddlStudentName.Items.Count > 0) { }
            else
            {
                BusinessLogic.Student students = new BusinessLogic.Student();
                try
                {
                    //flling the drop down with its data source
                    DataTable dt = students.getStudentNameDataTable();
                    ddlStudentName.DataValueField = "FLD_STUDENTID";
                    ddlStudentName.DataTextField = "Name";
                    ddlStudentName.DataSource = dt;
                    ddlStudentName.DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Failed to get database information. Error :" + ex);
                }
            }
        }
        protected void calLessonDate_SelectionChanged(object sender, EventArgs e)
        {
            whereDate = calLessonDate.SelectedDate;
            date = whereDate.Date.ToString("yyyy/MM/dd");
            try
            {
                //fill drop down with respective data
                BusinessLogic.Lesson lessons = new BusinessLogic.Lesson();
                DataTable dtls = lessons.getLessonDescriptionDataTable(date);
                ddlLesson.DataValueField = "fld_LessonID";
                ddlLesson.DataTextField = "fld_Description";
                ddlLesson.DataSource = dtls;
                ddlLesson.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }

        protected void btnRecord_Click(object sender, EventArgs e)
        {
            //Record the attendance entry into the db
            BusinessLogic.Student thisstud = new BusinessLogic.Student();
            try
            {
                thisstud.getStudent((int.Parse(ddlStudentName.SelectedValue.ToString())));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
            string success = "1";
            BusinessLogic.Attendance attendee = new BusinessLogic.Attendance(0, int.Parse(ddlLesson.SelectedValue.ToString()), int.Parse(ddlStudentName.SelectedValue), thisstud.GuardianId, calLessonDate.SelectedDate, attend);

            try
            {
                success = attendee.InsertToDatabase();
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
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }
        protected void ddlAttended_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check selected attendance
            if (ddlAttended.SelectedValue == "0")
            {
                attend = false;
            }
            if (ddlAttended.SelectedValue == "1")
            {
                attend = true;
            }
        }
    }
}