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

        public int ID { get => iD; set => iD = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool IsActive { get => isActive; set => isActive = value; }

        public string InsertToDatabase()
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "Insert into tbl_Employee (fld_FName,fld_LName,fld_ContactNo,fld_Email,fld_Password,fld_Active) " +
                    "values ('" + this.FName + "','" + this.LName + "','" + this.ContactNumber + "','" + this.Email + "','" + this.Password + "','" + this.IsActive + "')";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                result = "";
            }
            catch (Exception e)
            {
                result = "Error : " + e;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public string UpdateToDatabase(int EmployeeID)
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "update tbl_Employee  set " +
                    "fld_FName = '" + this.FName + "'," +
                    "fld_LName = '" + this.LName + "' ," +
                    "fld_ContactNo = '" + this.ContactNumber + "'," +
                    "fld_Email = '" + this.Email + "' ," +
                    "fld_Password = '" + this.Password + "' ," +
                    "fld_Active = '" + this.IsActive + "' ," + "' where fld_EmployeeID = '" + EmployeeID + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                result = "";
            }
            catch (Exception e)
            {
                result = "Error : " + e;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public string getEmployee(int employeeID)
        {
            string result = "";
            string sql = " select * from tbl_Employee where fld_EmployeeID = '" + employeeID + "'";
            connection.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    this.ID = int.Parse(dataReader.GetValue(0).ToString());
                    this.FName = (dataReader.GetValue(1).ToString());
                    this.LName = (dataReader.GetValue(2).ToString());
                    this.ContactNumber = (dataReader.GetValue(3).ToString());
                    this.Email = (dataReader.GetValue(4).ToString());
                    this.Password = (dataReader.GetValue(5).ToString());
                    this.IsActive = bool.Parse(dataReader.GetValue(6).ToString());

                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception NoResuslts)
            {
                result = "Error : " + NoResuslts;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public DataTable getDataTable()
        {
            DataTable dt = new DataTable();
            string query = "select * from tbl_Employee";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            da.Dispose();

            return dt;
        }
    }
}