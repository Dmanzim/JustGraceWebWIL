using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class MissingStudents : System.Web.UI.Page
    {

        string whereDate;
        bool attend = false;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserID"] == null)
            {

                Response.Redirect("Login.aspx");

            }

            BusinessLogic.Student students = new BusinessLogic.Student();

            DataTable dt = students.getStudentNameDataTable();

            ddlStudentName.DataValueField = "FLD_STUDENTID";
            ddlStudentName.DataTextField = "Name";

            ddlStudentName.DataSource = dt;
            ddlStudentName.DataBind();

            
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
            whereDate = calLessonDate.SelectedDate.ToString("yyyy/MM/dd");
            

            BusinessLogic.Lesson lessons = new BusinessLogic.Lesson();
            DataTable dtls = lessons.getLessonDescriptionDataTable(whereDate);

            ddlLesson.DataValueField = "fld_LessonID";
            ddlLesson.DataTextField = "fld_Description";

            ddlLesson.DataSource = dtls;
            ddlLesson.DataBind();
        }

        protected void btnRecord_Click(object sender, EventArgs e)
        {
            BusinessLogic.Student thisstud = new BusinessLogic.Student();
            thisstud.getStudent((int.Parse(ddlStudentName.SelectedValue.ToString())));

            BusinessLogic.Attendance attendee = new BusinessLogic.Attendance(0, int.Parse(ddlLesson.SelectedValue.ToString()), int.Parse(ddlStudentName.SelectedValue.ToString()), thisstud.GuardianId, whereDate, attend);

            attendee.InsertToDatabase();

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