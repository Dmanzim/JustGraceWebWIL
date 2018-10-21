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
    public partial class RptAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(ddlStudent.DataValueField.Count() > 0)
            {

            }
            else
            {
                BusinessLogic.Student studObj = new Student();

                DataTable dt = studObj.getStudentNameDataTable();

                ddlStudent.DataValueField = "FLD_STUDENTID";
                ddlStudent.DataTextField = "Name";

                ddlStudent.DataSource = dt;
                ddlStudent.DataBind();
            }
            

        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            String whereStatement = "";
            BusinessLogic.Attendance newAttendance = new BusinessLogic.Attendance();

            if (ddlStudent.Enabled)
            {
                whereStatement = whereStatement + "Where tbl_Student.FLD_STUDENTID = " + int.Parse(ddlStudent.SelectedValue.ToString()) + "";
            }
            if (CalDateTo.Visible)
            {
                if (ddlStudent.Enabled)
                {
                    whereStatement = whereStatement + " and FLD_DATERECORDED >= '" + CalDateFrom.SelectedDate + "' and FLD_DATERECORDED <= '" + CalDateTo.SelectedDate + "'";
                }
                else
                {
                    whereStatement = " where FLD_DATERECORDED >= '" + CalDateFrom.SelectedDate + "' and FLD_DATERECORDED <= '" + CalDateTo.SelectedDate + "'";
                }
            }

            DataTable dt = newAttendance.getAttendanceRptDataTable(whereStatement);

            gvAttendance.DataSource = dt;
            gvAttendance.DataBind();
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