using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class RptAbuse : System.Web.UI.Page
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

            DataTable dt = newAbuseReport.getAbuseRptDataTable(whereStatement); 

            gvAbuse.DataSource = dt;
            gvAbuse.DataBind();
        }
    }
}