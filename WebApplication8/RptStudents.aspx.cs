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
    public partial class RptStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the user is logged in or not. kick them out if they are not
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            //Check if the drop down box is populated and fill it if it isnt
            if (ddlStudent.DataValueField.Count() > 0){}
            else
            {
                //Get data table and fill the drop down list
                BusinessLogic.Student studObj = new BusinessLogic.Student();
                try
                {
                    if (ddlStudent.DataValueField.Count() > 0) { }
                    else
                    {
                        DataTable dt = studObj.getStudentNameDataTable();
                        ddlStudent.DataValueField = "FLD_STUDENTID";
                        ddlStudent.DataTextField = "Name";
                        ddlStudent.DataSource = dt;
                        ddlStudent.DataBind();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Failed to get database information. Error :" + ex);
                }
            }
        }
        protected void btnStudentFilter_Click(object sender, EventArgs e)
        {
            // disbale/enable drop down if button clicked
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
            //Refresh report and get data from the database. Where statement is compiled here
            String whereStatement = "";
            BusinessLogic.Student newAttendance = new BusinessLogic.Student();
            if (ddlStudent.Visible)
            {
                whereStatement = whereStatement + "Where tbl_Student.FLD_STUDENTID = " + int.Parse(ddlStudent.SelectedValue.ToString()) + "";
            }
            try
            {
                DataTable dt = newAttendance.getStudentReportDataTable(whereStatement);
                gvAttendance.DataSource = dt;
                gvAttendance.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }
    }
}