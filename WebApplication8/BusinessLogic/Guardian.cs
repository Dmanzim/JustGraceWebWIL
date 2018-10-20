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
        private int ID;
        private string fName, lName, contact, email, address;
        bool isActive;
        protected SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionStr);

        public Guardian(int iD, string fName, string lName, string contact, string email, string address, bool isActive)
        {
            ID = iD;
            this.fName = fName;
            this.lName = lName;
            this.contact = contact;
            this.email = email;
            this.address = address;
            this.isActive = isActive;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public bool IsActive { get => isActive; set => isActive = value; }

        public string InsertToDatabase()
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "Insert into tbl_Guardian (FLD_FNAME,FLD_LNAME,FLD_CONTACT,FLD_ACTIVE,FLD_EMAIL,FLD_ADDRESS,FLD_PASSWORD) " +
                    "values ('" + this.fName + "','" + this.LName + "','" + this.contact + "','" + this.isActive + "','" + this.email + "','" + this.address + "','" + this.p + "')";

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
        public string UpdateToDatabase(int lessonID)
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "update tbl_Guardian  set " +
                    "FLD_DATETIME = '" + this.LessonDate + "'," +
                    "FLD_DESCRIPTION = '" + this.description + "' ," +
                    "FLD_DURATIONHOURS = '" + this.durationInHours + "' ," +
                    ",FLD_STAFFID = '" + this.staffId + "' where fld_LessonID = '" + lessonID + "'";
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

        public string getStudent(int lessonID)
        {
            string result = "";
            string sql = " select *  from tbl_Guardian where fld_LessonID = '" + lessonID + "'";
            connection.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    this.ID = int.Parse(dataReader.GetValue(0).ToString());
                    this.LessonDate = DateTime.Parse(dataReader.GetValue(1).ToString());
                    this.description = (dataReader.GetValue(2).ToString());
                    this.durationInHours = double.Parse(dataReader.GetValue(3).ToString());
                    this.staffId = int.Parse(dataReader.GetValue(4).ToString());

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
            string query = "select * from tbl_Guardian";

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