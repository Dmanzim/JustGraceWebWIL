using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WIL_webSystem
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=justgrace.database.windows.net;Initial Catalog=ProjectGrace;User ID=WIL3;Password=********;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter SqlAdp = new SqlDataAdapter("Select fld_StudentID from tbl_Student where fld_StudentFname = " + txtUsername.Text + " and fld_Password = " + txtPassword.Text + "",con);
            SqlAdp.SelectCommand.CommandType = System.Data.CommandType.Text;
            SqlAdp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                btnLogin.Visible = false;
            }
            con.Close();
        }
    }
}