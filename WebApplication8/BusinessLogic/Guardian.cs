using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication8.BusinessLogic
{
    public class Guardian
    {
        //Declare variables for the class (attributes)
        private int ID;
        private string fName, lName, contact, email, address, password;
        bool isActive;
        protected SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionStr);

        //Custom constructor for this class
        public Guardian(int iD, string fName, string lName, string contact, string email, string address, bool isActive, string password)
        {
            ID = iD;
            this.FName1 = fName;
            this.LName1 = lName;
            this.Contact1 = contact;
            this.Email1 = email;
            this.Address1 = address;
            this.isActive = isActive;
            this.password = password;
        }
        //Default constructor for this class
        public Guardian()
        {
        }

        //Gets and sets for this class
        public int ID1 { get => ID; set => ID = value; }
        public string FName { get => FName1; set => FName1 = value; }
        public string LName { get => LName1; set => LName1 = value; }
        public string Contact { get => Contact1; set => Contact1 = value; }
        public string Email { get => Email1; set => Email1 = value; }
        public string Address { get => Address1; set => Address1 = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public string FName1 { get => fName; set => fName = value; }
        public string LName1 { get => lName; set => lName = value; }
        public string Contact1 { get => contact; set => contact = value; }
        public string Email1 { get => email; set => email = value; }
        public string Address1 { get => address; set => address = value; }
        public string Password { get => password; set => password = value; }

        //inserts into the database
        public string InsertToDatabase()
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "Insert into tbl_Guardian (FLD_FNAME,FLD_LNAME,FLD_CONTACT,FLD_ACTIVE,FLD_EMAIL,FLD_ADDRESS,FLD_PASSWORD) " +
                    "values ('" + this.FName1 + "','" + this.LName + "','" + this.Contact1 + "','" + this.isActive + "','" + this.Email1 + "','" + this.Address1 + "','" + this.password + "')";

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
        //Updates the databsed based on ID
        public string UpdateToDatabase(int guardianID)
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "update tbl_Guardian  set " +
                    "FLD_FNAME = '" + this.FName + "'," +
                    "FLD_LNAME = '" + this.LName + "' ," +
                    "FLD_CONTACT = '" + this.contact + "'," +
                    "FLD_ACTIVE = '" + this.IsActive + "' ," +
                    "FLD_EMAIL = '" + this.email + "' ," +
                    "FLD_ADDRESS = '" + this.address + "' ," +
                    "FLD_PASSWORD = '" + this.password + "' where fld_GuardianID = '" + guardianID + "'";
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
        //Gets the specified guardian using ID
        public string getGuardian(int guardianID)
        {
            string result = "";
            string sql = " select *  from tbl_Guardian where fld_GuardianID = '" + guardianID + "'";
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
                    this.contact = (dataReader.GetValue(3).ToString());
                    this.IsActive = bool.Parse(dataReader.GetValue(4).ToString());
                    this.email = (dataReader.GetValue(5).ToString());
                    this.address = (dataReader.GetValue(6).ToString());
                    this.password = (dataReader.GetValue(7).ToString());

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
        //Gets a datatable of the guardian table
        public DataTable getDataTable()
        {
            DataTable dt = new DataTable();
            string query = "select * from tbl_Guardian";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            da.Dispose();

            return dt;
        }
        //Gets a datatable for the guardian drop down
        public DataTable getGuardianDropDownDataTable()
        {
            DataTable dt = new DataTable();
            string query = "select FLD_GUARDIANID as [ID] , CONCAT(FLD_FNAME, ' ',FLD_LNAME ) as [Name] from tbl_Guardian";

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