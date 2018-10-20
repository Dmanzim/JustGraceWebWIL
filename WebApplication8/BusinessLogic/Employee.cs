using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication8.BusinessLogic
{
    public class Employee
    {
        private int iD;
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
            this.iD = ID;
            this.fName = fName;
            this.lName = lName;
            this.contactNumber = contactNumber;
            this.email = email;
            this.password = password;
            this.isActive = isActive;
        }

        public int ID { get => ID; set => ID = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
    }
}