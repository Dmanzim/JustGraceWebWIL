﻿using System;
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

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}