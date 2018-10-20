using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication8.BusinessLogic
{
    public class AbuseReport
    {
        private int iD, recordedBy, studentId, guardianId;
        private string description, actionTaken, comment;
        private DateTime date;
        protected SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionStr);


        public AbuseReport(int ID, int recordedBy, int studentId, int guardianId, string description, string actionTaken, string comment, DateTime date)
        {
            this.iD = ID;
            this.recordedBy = recordedBy;
            this.studentId = studentId;
            this.guardianId = guardianId;
            this.description = description;
            this.actionTaken = actionTaken;
            this.comment = comment;
            this.date = date;
        }

        public int ID { get => iD; set => iD = value; }
        public int RecordedBy { get => recordedBy; set => recordedBy = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int GuardianId { get => guardianId; set => guardianId = value; }
        public string Description { get => description; set => description = value; }
        public string ActionTaken { get => actionTaken; set => actionTaken = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime Date { get => date; set => date = value; }

        public string InsertToDatabase()
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "Insert into tbl_AbuseReport (fld_Description,fld_ActionTaken,fld_Comment,fld_Date,fld_RecordedBy,fld_StudentID,fld_GuardianID) " +
                    "values ('" + this.Description + "','" + this.ActionTaken + "','" + this.Comment + "','" + this.Date + "','" + this.RecordedBy + "','" + this.StudentId + "','" + this.GuardianId + "')";

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
        public string UpdateToDatabase(int reportID)
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "update tbl_AbuseReport  set " +
                    "fld_Description = '" + this.Description + "'," +
                    "fld_ActionTaken = '" + this.ActionTaken + "' ," +
                    "fld_Comment = '" + this.Comment + "'," +
                    "fld_Date = '" + this.Date + "' ," +
                    "fld_RecordedBy = '" + this.RecordedBy + "' ," +
                    "fld_StudentID = '" + this.StudentId + "' ," +
                    "fld_GuardianID = '" + this.GuardianId + "' where fld_GuardianID = '" + reportID + "'";
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

        public string getAbuseReport(int reportID)
        {
            string result = "";
            string sql = " select *  from tbl_AbuseReport where fld_AbuseID = '" + reportID + "'";
            connection.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    this.ID = int.Parse(dataReader.GetValue(0).ToString());
                    this.Description = (dataReader.GetValue(1).ToString());
                    this.ActionTaken = (dataReader.GetValue(2).ToString());
                    this.Comment = (dataReader.GetValue(3).ToString());
                    this.Date = DateTime.Parse(dataReader.GetValue(4).ToString());
                    this.RecordedBy = int.Parse(dataReader.GetValue(5).ToString());
                    this.StudentId = int.Parse(dataReader.GetValue(6).ToString());
                    this.GuardianId = int.Parse(dataReader.GetValue(7).ToString());

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
            string query = "select * from tbl_AbuseReport";

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