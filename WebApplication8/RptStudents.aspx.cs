using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class RptStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {

                Response.Redirect("Login.aspx");

            }

            if (ddlStudent.DataValueField.Count() > 0)
            {

            }
            else
            {
                BusinessLogic.Student studObj = new BusinessLogic.Student();

                DataTable dt = studObj.getStudentNameDataTable();

                ddlStudent.DataValueField = "FLD_STUDENTID";
                ddlStudent.DataTextField = "Name";

                ddlStudent.DataSource = dt;
                ddlStudent.DataBind();
            }
        }

        protected void btnStudentFilter_Click(object sender, EventArgs e)
        {
            if (ddlStudent.Visible)
            {
                ddlStudent.Visible = false;
            }
            else
            {
                ddlStudent.Visible = true;
            }
        }

        

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            String whereStatement = "";
            BusinessLogic.Student newAttendance = new BusinessLogic.Student();

            if (ddlStudent.Visible)
            {
                whereStatement = whereStatement + "Where tbl_Student.FLD_STUDENTID = " + int.Parse(ddlStudent.SelectedValue.ToString()) + "";
            }            

            DataTable dt = newAttendance.getStudentReportDataTable(whereStatement);

            gvAttendance.DataSource = dt;
            gvAttendance.DataBind();
        }
    }
}