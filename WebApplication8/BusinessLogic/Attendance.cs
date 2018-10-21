using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication8.BusinessLogic
{
    public class Attendance
    {
        private int iD, lessonId, studentId, guardianId;
        private string dateRecorded;
        bool didAttend;
        protected SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionStr);

        public Attendance(int ID, int lessonId, int studentId, int guardianId, string dateRecorded, bool didAttend)
        {
            this.iD = ID;
            this.lessonId = lessonId;
            this.studentId = studentId;
            this.guardianId = guardianId;
            this.dateRecorded = dateRecorded;
            this.didAttend = didAttend;
        }

        public Attendance()
        {
        }

        public int ID { get => iD; set => iD = value; }
        public int LessonId { get => lessonId; set => lessonId = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int GuardianId { get => guardianId; set => guardianId = value; }
        public string DateRecorded { get => dateRecorded; set => dateRecorded = value; }
        public bool DidAttend { get => didAttend; set => didAttend = value; }

        public string InsertToDatabase()
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "Insert into tbl_Attendance (fld_LessonID,fld_StudentID,fld_DateRecorded,fld_GuardianID,fld_DidAttend) " +
                    "values ('" + this.LessonId + "','" + this.StudentId + "','" + this.DateRecorded + "','" + this.GuardianId + "','" + this.DidAttend + "')";

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
        public string UpdateToDatabase(int AttendanceID)
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "update tbl_Attendance  set " +
                    "fld_LessonID = '" + this.LessonId + "'," +
                    "fld_StudentID = '" + this.StudentId + "' ," +
                    "fld_DateRecorded = '" + this.DateRecorded + "'," +
                    "fld_GuardianID = '" + this.GuardianId + "' ," +
                    "fld_DidAttend = '" + this.DidAttend + "' ," + "' where fld_AttendanceID = '" + AttendanceID + "'";
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

        public string getAttendance(int attendanceID)
        {
            string result = "";
            string sql = " select * from tbl_Attendance where fld_AttendanceID = '" + attendanceID + "'";
            connection.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    this.ID = int.Parse(dataReader.GetValue(0).ToString());
                    this.LessonId = int.Parse(dataReader.GetValue(1).ToString());
                    this.StudentId = int.Parse(dataReader.GetValue(2).ToString());
                    this.DateRecorded = (dataReader.GetValue(3).ToString());
                    this.GuardianId = int.Parse(dataReader.GetValue(4).ToString());
                    this.DidAttend = bool.Parse(dataReader.GetValue(5).ToString());

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
            string query = "select * from tbl_Attendance";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            da.Dispose();

            return dt;
        }
        public DataTable getAttendanceRptDataTable(String whereStatement)
        {
            string query = "";
            DataTable dt = new DataTable();
            if (whereStatement == "")
            {
                query = "select tbl_attendance.FLD_DATERECORDED as [Date], " +
                    "CONCAT(tbl_Student.FLD_STUDFNAME, ' ',tbl_Student.FLD_STUDLNAME ) as [Student Name]," +
                    "CONCAT(tbl_Guardian.FLD_FNAME, ' ', tbl_Guardian.FLD_LNAME) as [Guardian Name], " +
                    "tbl_Guardian.FLD_CONTACT as [Contact Number] ," +
                    "tbl_attendance.FLD_Didattend as [Attended Session] from tbl_attendance " +
                    "join tbl_Student on tbl_attendance.FLD_STUDENTID = tbl_Student.FLD_STUDENTID " +
                    "join tbl_Guardian on tbl_attendance.FLD_GUARDIANID = tbl_Guardian.FLD_GUARDIANID";
            }
            else
            {
                query = "select tbl_attendance.FLD_DATERECORDED as [Date], " +
                    "CONCAT(tbl_Student.FLD_STUDFNAME, ' ',tbl_Student.FLD_STUDLNAME ) as [Student Name]," +
                    "CONCAT(tbl_Guardian.FLD_FNAME, ' ', tbl_Guardian.FLD_LNAME) as [Guardian Name], " +
                    "tbl_Guardian.FLD_CONTACT as [Contact Number] ," +
                    "tbl_attendance.FLD_Didattend as [Attended Session] from tbl_attendance " +
                    "join tbl_Student on tbl_attendance.FLD_STUDENTID = tbl_Student.FLD_STUDENTID " +
                    "join tbl_Guardian on tbl_attendance.FLD_GUARDIANID = tbl_Guardian.FLD_GUARDIANID " +
                    ""+whereStatement+"";
            }
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(dt);
            }
            catch
            {
                query = "select tbl_attendance.FLD_DATERECORDED as [Date], " +
                    "CONCAT(tbl_Student.FLD_STUDFNAME, ' ',tbl_Student.FLD_STUDLNAME ) as [Student Name]," +
                    "CONCAT(tbl_Guardian.FLD_FNAME, ' ', tbl_Guardian.FLD_LNAME) as [Guardian Name], " +
                    "tbl_Guardian.FLD_CONTACT as [Contact Number]," +
                    "tbl_attendance.FLD_Didattend as [Attended Session] from tbl_attendance " +
                    "join tbl_Student on tbl_attendance.FLD_STUDENTID = tbl_Student.FLD_STUDENTID " +
                    "join tbl_Guardian on tbl_attendance.FLD_GUARDIANID = tbl_Guardian.FLD_GUARDIANID";

                cmd = new SqlCommand(query, connection);
                da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            connection.Close();
            da.Dispose();

            return dt;
        }
    }
}