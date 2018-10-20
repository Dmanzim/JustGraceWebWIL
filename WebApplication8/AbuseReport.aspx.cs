using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class AbuseReport : System.Web.UI.Page
    {
        back.SQLConnect sqlConn ;
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlConn = new back.SQLConnect();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            

            sqlConn.AddRecord("insert into tbl_AbuseReport(fld_Description, fld_ActionTaken, fld_Comment, fld_Date, fld_RecordedBy, fld_StudentID, fld_GuardianID) values", data);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}