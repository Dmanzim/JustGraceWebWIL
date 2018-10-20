using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class AbuseReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BusinessLogic.Student students = new BusinessLogic.Student();

            DataTable dt = students.getStudentNameDataTable();

            ddlStudentName.DataValueField = "FLD_STUDENTID";
            ddlStudentName.DataTextField = "Name";

            ddlStudentName.DataSource = dt;
            ddlStudentName.DataBind();

            if (Session["userID"] != null)
            {
                txtDescription.Text = Session["userID"].ToString();
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {



        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}