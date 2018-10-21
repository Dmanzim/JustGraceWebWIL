using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class RecordLessonSchedule : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserID"] == null)
            {

                Response.Redirect("Login.aspx");

            }

            BusinessLogic.Employee tempEmployee = new BusinessLogic.Employee();

            DataTable dt = tempEmployee.getEmployeeTeachersNameDataTable();

            ddlTeacher.DataValueField = "fld_EmployeeID";
            ddlTeacher.DataTextField = "Name";

            ddlTeacher.DataSource = dt;
            ddlTeacher.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int staffId = int.Parse(ddlTeacher.SelectedValue.ToString());
            BusinessLogic.Lesson newlesson = new BusinessLogic.Lesson(0,staffId,txtDescription.Text,calLessonDate.SelectedDate.ToString("yyyy/MM/dd"), double.Parse(txtHours.Text));
            string returnedStatus = newlesson.InsertToDatabase();
            if(returnedStatus != "")
            {
                txtDescription.Text = returnedStatus;
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}