using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class MissingStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            BusinessLogic.Student students = new BusinessLogic.Student();

            DataTable dt = students.getStudentNameDataTable();

            ddlStudentName.DataValueField = "FLD_STUDENTID";
            ddlStudentName.DataTextField = "Name";

            ddlStudentName.DataSource = dt;
            ddlStudentName.DataBind();
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}