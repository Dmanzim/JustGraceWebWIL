using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {

                Response.Redirect("Login.aspx");

            }
        }

        protected void BtnAbuseReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("AbuseReport.aspx");
        }

        protected void btnGuardianSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("GuardianSignUp.aspx");
        }

        protected void btnMissingStudents_Click(object sender, EventArgs e)
        {
            Response.Redirect("MissingStudents.aspx");
        }

        protected void btnPushNotification_Click(object sender, EventArgs e)
        {
            Response.Redirect("PushNotification.aspx");
        }

        protected void btnRecordEducator_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecordEducator.aspx");
        }

        protected void btnRecordLessonSchedule_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecordLessonSchedule.aspx");
        }

        protected void btnRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}