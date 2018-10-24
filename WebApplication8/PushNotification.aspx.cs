using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication8.BusinessLogic;

namespace WebApplication8
{
    public partial class PushNotification : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if the user is logged in or not. kick them out if they are not
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Save Push notification to db
            bool isStaff = chkSendToEmployee.Checked;
            bool isForStudent = chkSendToStudent.Checked;
            bool isForGuardian = chkSendToGuardian.Checked;

            int employeeID = int.Parse(Session["UserID"].ToString());

            BusinessLogic.PushNotification newNotification = new BusinessLogic.PushNotification(0, employeeID, txtDescription.Text, txtMessage.Text, false, isStaff, isForStudent, isForGuardian,  DateTime.Now);

            try
            {
                string result = newNotification.InsertToDatabase();

                if (result != "")
                {
                    MessageBox.Show(this.Page, "Error :" + result);
                }
                else
                {
                    txtDescription.Text = "";
                    txtMessage.Text = "";
                    MessageBox.Show(this.Page, "Successfully saved notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to get database information. Error :" + ex);
            }

        }

    }
}