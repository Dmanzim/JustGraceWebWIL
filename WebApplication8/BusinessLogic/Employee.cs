using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication8.BusinessLogic
{
    public class Employee
    {
        //Declare variables for the class (attributes)
        private int iD, employeeTypeId;
        private string fName, lName, contactNumber, email, password;
        private bool isActive;
        protected SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionStr);

        //Default constructor for this class
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
        //Custom constructor for this class
        public Employee(int iD, string fName, string lName, string contactNumber, string email, string password, bool isActive, int employeeTypeID)
        {
            this.ID1 = ID;
            this.fName = fName;
            this.lName = lName;
            this.contactNumber = contactNumber;
            this.email = email;
            this.password = password;
            this.isActive = isActive;
            this.employeeTypeId = employeeTypeID;
        }
        //Gets and sets for this class
        public int ID { get => ID1; set => ID1 = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public int ID1 { get => iD; set => iD = value; }
        public int EmployeeTypeId { get => employeeTypeId; set => employeeTypeId = value; }


        //Used to validate the user  information
        public bool loginEmployee()
        {
            bool loggedIn = false;

            connection.Open();

            string sql = "select fld_EmployeeID from tbl_Employee where fld_email = '" + this.email + "' and fld_Password = '" + this.password + "'";

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    this.ID = int.Parse(dataReader.GetValue(0).ToString());
                    loggedIn = true;

                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return loggedIn;
        }
        //Inserts a new employee into the database
        public string InsertToDatabase()
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "Insert into tbl_Employee (fld_FName,fld_LName,fld_ContactNo,fld_Email,fld_Password,fld_Active, fld_EmployeeTypeID) " +
                    "values ('" + this.FName + "','" + this.LName + "','" + this.ContactNumber + "','" + this.Email + "','" + this.Password + "','" + this.IsActive + "','" + this.employeeTypeId + "')";

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
        //Updates the database 
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
                    "fld_Active = '" + this.IsActive + "' ," +
                    "fld_EmployeeTypeID = '" + this.employeeTypeId + "' ," + "' where fld_EmployeeID = '" + EmployeeID + "'";
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
        //Gets the employee info from the db based of the ID
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
                    this.employeeTypeId = int.Parse(dataReader.GetValue(7).ToString());

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
        //Gets a datatable for the employee table 
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
        //Gets a datatable of the teachers 
        public DataTable getEmployeeTeachersNameDataTable()
        {
            DataTable dt = new DataTable();
            string query = "select fld_EmployeeID, CONCAT(FLD_FNAME, ' ',FLD_LNAME) as [Name]  from tbl_Employee where fld_EmployeeTypeID = 2";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            da.Dispose();

            return dt;
        }
        //Gets a datatable of the admins 
        public DataTable getEmployeeAdminNameDataTable()
        {
            DataTable dt = new DataTable();
            string query = "select fld_EmployeeID, CONCAT(FLD_FNAME, ' ',FLD_LNAME) as [Name]  from tbl_Employee where fld_EmployeeTypeID = 1 ";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            da.Dispose();

            return dt;
        }
        //Gets a datatable of the employee types for the drop down
        public DataTable getEmployeeTypeDataTable()
        {
            DataTable dt = new DataTable();
            string query = "select FLD_EMPLOYEETYPEID as [ID],  FLD_DESCRIPTION as [Name] from tbl_employeetype";

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