using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class rptLessons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["UserID"] == null)
            //{

            //    Response.Redirect("Login.aspx");

            //}

            if (ddlEmployee.DataValueField.Count() > 0)
            {

            }
            else
            {
                BusinessLogic.Employee EmpObj = new BusinessLogic.Employee();

                DataTable dt = EmpObj.getEmployeeTeachersNameDataTable();

                ddlEmployee.DataValueField = "fld_EmployeeID";
                ddlEmployee.DataTextField = "Name";

                ddlEmployee.DataSource = dt;
                ddlEmployee.DataBind();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            String whereStatement = "";
            BusinessLogic.Lesson newAttendance = new BusinessLogic.Lesson();

            if (ddlEmployee.Visible)
            {
                whereStatement = whereStatement + "Where tbl_Lesson.FLD_EMPLOYEEID = " + int.Parse(ddlEmployee.SelectedValue.ToString()) + "";
            }
            if (CalDateTo.Visible)
            {
                if (ddlEmployee.Visible)
                {
                    whereStatement = whereStatement + " and tbl_Lesson.FLD_DATE >= '" + CalDateFrom.SelectedDate + "' and tbl_Lesson.FLD_DATE <= '" + CalDateTo.SelectedDate + "'";
                }
                else
                {
                    whereStatement = " where tbl_Lesson.FLD_DATE >= '" + CalDateFrom.SelectedDate + "' and tbl_Lesson.FLD_DATE <= '" + CalDateTo.SelectedDate + "'";
                }
            }

            DataTable dt = newAttendance.getReportDataTable(whereStatement);

            gvLessons.DataSource = dt;
            gvLessons.DataBind();
        }

        protected void btnStudentFilter_Click(object sender, EventArgs e)
        {
            if (ddlEmployee.Visible)
            {
                ddlEmployee.Visible = false;
            }
            else
            {
                ddlEmployee.Visible = true;
            }
        }

        protected void btnDateFilter_Click(object sender, EventArgs e)
        {
            if (CalDateTo.Visible)
            {
                CalDateTo.Visible = false;
                CalDateFrom.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
            }
            else
            {
                CalDateTo.Visible = true;
                CalDateFrom.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;

            }
        }
    }
}