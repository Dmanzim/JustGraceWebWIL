﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication8.BusinessLogic
{
    public class Student
    {
        private int ID, guardianId;
        private string fName, lName, password, email;
        private bool isActive;
        protected SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionStr);



        public Student(int iD, int guardianId, string fName, string lName, string password, bool isActive, string email)
        {
            ID = iD;
            this.guardianId = guardianId;
            this.fName = fName;
            this.lName = lName;
            this.password = password;
            this.isActive = isActive;
            this.email = email;
        }

        public int ID1 { get => ID; set => ID = value; }
        public int GuardianId { get => guardianId; set => guardianId = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Password { get => password; set => password = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public string FName1 { get => fName; set => fName = value; }
        public string LName1 { get => lName; set => lName = value; }
        public string Password1 { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        public string  InsertToDatabase()
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "Insert into tbl_student (fld_StudFName,FLD_STUDLNAME,FLD_PASSWORD,FLD_ACTIVE,FLD_GUARDIANID,FLD_EMAIL) " +
                    "values ('" + this.FName + "','" + this.lName + "','" + this.password + "','" + this.isActive + "', '" + this.guardianId + ", '" + this.email + "'')";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                result = "";
            }
            catch(Exception e)
            {
                result = "Error : " + e;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public string UpdateToDatabase(int studentID)
        {
            string result = "";
            connection.Open();
            try
            {
                string sql = "update tbl_student  set " +
                    "fld_StudFName = '" + this.FName + "'," +
                    "FLD_STUDLNAME = '" + this.lName + "' ," +
                    "FLD_PASSWORD = '" + this.password + "' ," +
                    "FLD_ACTIVE = '" + this.isActive + "' , " +
                    "FLD_GUARDIANID = '" + this.guardianId + "'" +
                    ",FLD_EMAIL = '" + this.email + "'";
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

        public string getStudent(int studentID)
        {
            string result = "";
            string sql = " select *  from tbl_Student where fld_StudentId = '"+ studentID +"'";
            connection.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    
                    this.ID = int.Parse(dataReader.GetValue(0).ToString());              
                    this.fName = dataReader.GetValue(1).ToString();               
                    this.LName = dataReader.GetValue(2).ToString();               
                    this.password = dataReader.GetValue(3).ToString();                
                    this.isActive = bool.Parse(dataReader.GetValue(4).ToString());                
                    this.guardianId = int.Parse(dataReader.GetValue(5).ToString());
                    this.email = dataReader.GetValue(6).ToString();
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception NoResuslts)
            {
                result = "Error : " + NoResuslts;
            }
            finally {
                connection.Close();
            }
                return result;
        }
    }
}