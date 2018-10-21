using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApplication8.BusinessLogic
{
    public class PushNotification
    {
        private int ID, employeeID;
        private string description, message;
        private bool sent, isStaff, isForStudent, isForGuardian;
        private DateTime date;
        protected SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionStr);

        public PushNotification(int iD, int employeeID, string description, string message, bool sent, bool isStaff, bool isForStudent, bool isForGuardian, DateTime date)
        {
            ID = iD;
            this.employeeID = employeeID;
            this.description = description;
            this.message = message;
            this.sent = sent;
            this.isStaff = isStaff;
            this.isForStudent = isForStudent;
            this.isForGuardian = isForGuardian;
            this.date = date;
        }

        public int ID1 { get => ID; set => ID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string Description { get => description; set => description = value; }
        public string Message { get => message; set => message = value; }
        public bool Sent { get => sent; set => sent = value; }
        public bool IsStaff { get => isStaff; set => isStaff = value; }
        public bool IsForStudent { get => isForStudent; set => isForStudent = value; }
        public bool IsForGuardian { get => isForGuardian; set => isForGuardian = value; }
        public DateTime Date { get => date; set => date = value; }

        public string InsertToDatabase()
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "Insert into tbl_PushNotification (FLD_DESCRIPTION,FLD_MESSAGE,FLD_SENT,FLD_DATE,FLD_ISSTAFF,FLD_ISSTUDENT,FLD_ISGUARDIAN,FLD_EmployeeID) " +
                    "values ('" + this.description + "','" + this.message + "','" + this.sent + "','" + this.date + "','" + this.isStaff + "','" + this.isForStudent + "', '" + this.isForGuardian + ", '" + this.employeeID + "'')";

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
        public string UpdateToDatabase(int PushNotificationID)
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "update tbl_PushNotification  set " +
                    "FLD_DESCRIPTION = '" + this.description + "'," +
                    "FLD_MESSAGE = '" + this.message + "' ," +
                    "FLD_SENT = '" + this.sent + "' ," +
                    "FLD_DATE = '" + this.date + "' , " +
                    "FLD_ISSTAFF = '" + this.isStaff + "'," +
                    "FLD_ISSTUDENT = '" + this.isForStudent + "'," +
                    "FLD_ISGUARDIAN = '" + this.isForGuardian + "'," +
                    ",FLD_EmployeeID = '" + this.employeeID + "' where fld_PushId = '"+ PushNotificationID + "'";
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

        public string getPushNotification(int PushNotificationID)
        {
            string result = "";
            string sql = " select *  from tbl_PushNotification where fld_PushId = '" + PushNotificationID + "'";
            connection.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    this.ID = int.Parse(dataReader.GetValue(0).ToString());
                    this.description = dataReader.GetValue(1).ToString();
                    this.message = dataReader.GetValue(2).ToString();
                    this.sent = bool.Parse(dataReader.GetValue(3).ToString());
                    this.date = DateTime.Parse(dataReader.GetValue(4).ToString());
                    this.isStaff = bool.Parse(dataReader.GetValue(5).ToString());
                    this.isForStudent = bool.Parse(dataReader.GetValue(6).ToString());
                    this.isForGuardian = bool.Parse(dataReader.GetValue(7).ToString());
                    this.employeeID = int.Parse(dataReader.GetValue(8).ToString());
                    
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
            string query = "select * from tbl_PushNotification";
            
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