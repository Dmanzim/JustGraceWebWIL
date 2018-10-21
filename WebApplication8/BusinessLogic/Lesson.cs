﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication8.BusinessLogic
{
    public class Lesson
    {
        private int ID, employeeId;
        private string description;
        private string lessonDate;
        private double durationInHours;

        protected SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionStr);

        public Lesson()
        {

        }
        public Lesson(int iD, int employeeId, string description, string lessonDate, double durationInHours)
        {
            ID = iD;
            this.employeeId = employeeId;
            this.description = description;
            this.lessonDate = lessonDate;
            this.durationInHours = durationInHours;
        }

       

        public int ID1 { get => ID; set => ID = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string Description { get => description; set => description = value; }
        public string LessonDate { get => lessonDate; set => lessonDate = value; }
        public double DurationInHours { get => durationInHours; set => durationInHours = value; }

        public string InsertToDatabase()
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "Insert into tbl_Lesson (FLD_DATE,FLD_DESCRIPTION,FLD_DURATIONHOURS,FLD_EMPLOYEEID) " +
                    "values (" + this.LessonDate + ",'" + this.description + "','" + this.durationInHours + "','" + this.employeeId + "')";

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
                string sql = "update tbl_Lesson  set " +
                    "FLD_DATETIME = '" + this.LessonDate + "'," +
                    "FLD_DESCRIPTION = '" + this.description + "' ," +
                    "FLD_DURATIONHOURS = '" + this.durationInHours + "' ," +
                    ",FLD_EMPLOYEEID = '" + this.employeeId + "' where fld_LessonID = '" + lessonID + "'";
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

        public string getLesson(int lessonID)
        {
            string result = "";
            string sql = " select *  from tbl_Lesson where fld_LessonID = '" + lessonID + "'";
            connection.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                    this.ID = int.Parse(dataReader.GetValue(0).ToString());
                    this.LessonDate = (dataReader.GetValue(1).ToString());
                    this.description = (dataReader.GetValue(2).ToString());
                    this.durationInHours = double.Parse(dataReader.GetValue(3).ToString());
                    this.employeeId = int.Parse(dataReader.GetValue(4).ToString());

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
            string query = "select * from tbl_Lesson";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            da.Dispose();

            return dt;
        }
        public DataTable getReportDataTable(String whereStatement)
        {
            string query = "";
            DataTable dt = new DataTable();
            if (whereStatement == "")
            {
                query = "select tbl_Lesson.FLD_DATE as [Date], " +
                    "tbl_Lesson.FLD_DESCRIPTION as [Description]," +
                    "tbl_Lesson.FLD_DURATIONHOURS as [Duration In Hours], " +
                    "CONCAT(tbl_employee.FLD_FNAME, ' ',tbl_employee.FLD_LNAME ) as [Employee Name]  " +
                    "from tbl_Lesson " +
                    "join tbl_employee on tbl_Lesson.FLD_EMPLOYEEID = tbl_employee.FLD_EMPLOYEEID";
            }
            else
            {
                query = "select tbl_Lesson.FLD_DATE as [Date], " +
                                    "tbl_Lesson.FLD_DESCRIPTION as [Description]," +
                                    "tbl_Lesson.FLD_DURATIONHOURS as [Duration In Hours], " +
                                    "CONCAT(tbl_employee.FLD_FNAME, ' ',tbl_employee.FLD_LNAME ) as [Employee Name]  " +
                                    "from tbl_Lesson " +
                                    "join tbl_employee on tbl_Lesson.FLD_EMPLOYEEID = tbl_employee.FLD_EMPLOYEEID " +
                                    " " + whereStatement + " ";
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
                query = "select tbl_Lesson.FLD_DATE as [Date], " +
                                    "tbl_Lesson.FLD_DESCRIPTION as [Description]," +
                                    "tbl_Lesson.FLD_DURATIONHOURS as [Duration In Hours], " +
                                    "CONCAT(tbl_employee.FLD_FNAME, ' ',tbl_employee.FLD_LNAME ) as [Employee Name]  " +
                                    "from tbl_Lesson " +
                                    "join tbl_employee on tbl_Lesson.FLD_EMPLOYEEID = tbl_employee.FLD_EMPLOYEEID";

                cmd = new SqlCommand(query, connection);
                da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            connection.Close();
            da.Dispose();

            return dt;
        }

        public DataTable getLessonDescriptionDataTable(string where)
        {
            DataTable dt = new DataTable();
            string query = "select FLD_lessonID, fld_description from tbl_Lesson where fld_Date = '" + where + "'";

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