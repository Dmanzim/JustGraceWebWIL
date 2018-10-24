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
    public partial class RecordLessonSchedule : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the user is logged in or not. kick them out if they are not
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            BusinessLogic.Employee tempEmployee = new BusinessLogic.Employee();
            try
            {
                if (ddlTeacher.DataValueField.Count() > 0) { }
                else
                {
                    DataTable dt = tempEmployee.getEmployeeTeachersNameDataTable();
                    ddlTeacher.DataValueField = "fld_EmployeeID";
                    ddlTeacher.DataTextField = "Name";
                    ddlTeacher.DataSource = dt;
                    ddlTeacher.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Register new lesson into the database
            int staffId = int.Parse(ddlTeacher.SelectedValue.ToString());
            BusinessLogic.Lesson newlesson = new BusinessLogic.Lesson(0,staffId,txtDescription.Text,calLessonDate.SelectedDate, double.Parse(txtHours.Text));
            try
            {
                string returnedStatus = newlesson.InsertToDatabase();
                if (returnedStatus != "")
                {
                    txtDescription.Text = returnedStatus;
                    MessageBox.Show(this, "Error occured. Error : "+ returnedStatus);
                }
                else
                {
                    MessageBox.Show(this, "Lesson scheduled successfully.");
                    txtDescription.Text = "";
                    txtHours.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
                
            }
        }

    }
}