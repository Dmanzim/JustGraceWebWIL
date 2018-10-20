using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication8.BusinessLogic
{
    public class Employee
    {
        private int ID;
        private string fName, lName, contactNumber, email, password;
        private bool isActive;
        protected SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionStr);

        public Employee()
        {
            this.ID = 0;
            this.fName = "";
            this.lName = "";
            this.contactNumber = "";
            this.email = "";
            this.password = "";
            this.isActive = false;
        }
        public Employee(int iD, string fName, string lName, string contactNumber, string email, string password, bool isActive)
        {
            ID = iD;
            this.fName = fName;
            this.lName = lName;
            this.contactNumber = contactNumber;
            this.email = email;
            this.password = password;
            this.isActive = isActive;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool IsActive { get => isActive; set => isActive = value; }

        public bool loginEmployee()
        {
            bool loggedIn = false;

            connection.Open();
            
                string sql = "select fld_Password from tbl_Employee where fld_email = '" + this.email + "' and fld_Password = '" + this.password + "'";
                
            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    loggedIn = true;

                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception NoResuslts)
            {
            }
            finally
            {
                connection.Close();
            }

            return loggedIn;
        }
    }
}