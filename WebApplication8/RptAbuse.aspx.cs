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
    public partial class RptAbuse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the user is logged in or not. kick them out if they are not
            if (Session["UserID"] == null)
            {

                Response.Redirect("Login.aspx");

            }
            //Check if the drop down box is populated and fill it if it isnt
            if (ddlStudent.DataValueField.Count() > 0){ }
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

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            String whereStatement = "";
            BusinessLogic.AbuseReport newAbuseReport = new BusinessLogic.AbuseReport();

            if (ddlStudent.Visible)
            {
                whereStatement = whereStatement + "Where tbl_abuseReport.FLD_STUDENTID = " + int.Parse(ddlStudent.SelectedValue.ToString()) + "";
            }
            if (CalDateTo.Visible)
            {
                if (ddlStudent.Visible)
                {
                    whereStatement = whereStatement + " and tbl_abuseReport.FLD_DATE >= '" + CalDateFrom.SelectedDate + "' and tbl_abuseReport.FLD_DATE <= '" + CalDateTo.SelectedDate + "'";
                }
                else
                {
                    whereStatement = " where tbl_abuseReport.FLD_DATE >= '" + CalDateFrom.SelectedDate + "' and tbl_abuseReport.FLD_DATE <= '" + CalDateTo.SelectedDate + "'";
                }
            }
            try
            {
                DataTable dt = newAbuseReport.getAbuseRptDataTable(whereStatement);
                gvAbuse.DataSource = dt;
                gvAbuse.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }
        }
    }
}