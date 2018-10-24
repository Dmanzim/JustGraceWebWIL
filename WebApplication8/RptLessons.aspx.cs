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
    public partial class rptLessons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the user is logged in or not. kick them out if they are not
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            //Check if the drop down box is populated and fill it if it isnt
            if (ddlEmployee.DataValueField.Count() > 0){  }
            else
            {
                //Get data table and fill the drop down list
                BusinessLogic.Employee EmpObj = new BusinessLogic.Employee();
                try
                {
                    if (ddlEmployee.DataValueField.Count() > 0) { }
                    else
                    {
                        DataTable dt = EmpObj.getEmployeeTeachersNameDataTable();
                        ddlEmployee.DataValueField = "fld_EmployeeID";
                        ddlEmployee.DataTextField = "Name";
                        ddlEmployee.DataSource = dt;
                        ddlEmployee.DataBind();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Failed to get database information. Error :" + ex);
                }
            }
        }
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            // Check which filters are available and add build them on to the where statement
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
            //set the data table based on the returned data
            try
            {
                DataTable dt = newAttendance.getReportDataTable(whereStatement);
                gvLessons.DataSource = dt;
                gvLessons.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }
        protected void btnStudentFilter_Click(object sender, EventArgs e)
        {
            // disbale/enable drop down if button clicked
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
            // disbale/enable date picker if button clicked
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