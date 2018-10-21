using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class RecordEducator : System.Web.UI.Page
    {
        back.SQLConnect sqlConn ;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["UserID"] == null)
            //{

            //    Response.Redirect("Login.aspx");

            //}

            sqlConn = new back.SQLConnect();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}