using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication8.BusinessLogic;

namespace WebApplication8
{
    public partial class GuardianSignUp : System.Web.UI.Page
    {
        string FirstName;
        string Surname;
        string Password;
        string Email;
        string Address;
        string ContactNo;
        int IdNumber;



        back.SQLConnect sqlConn;
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
            
            FirstName = txtFirstName.Text;
            Surname = txtSurname.Text;
            Password = txtPassword.Text;
            Email = txtEmail.Text;
            Address = txtAddress.Text;
            ContactNo = txtContactNo.Text;
            IdNumber = int.Parse(txtIdNumber.Text.ToString());

            
            Guardian Guard = new Guardian(IdNumber, FirstName, Surname, ContactNo, Email, Address, true, Password);
            if(!Guard.InsertToDatabase().Equals(""))
            {
                 
                lblRegisterSuccess.Text= "Error";
            }
                
                
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}