﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back
{
    
    public class SQLConnect
    {
        string connetionString;
        SqlConnection connection;
        SqlCommand command;
        string sql;

        public SQLConnect()
        {
            connetionString = "Data Source=justgrace.database.windows.net;Initial Catalog=wil3;Persist Security Info=True;User ID=WIL3;Password=Xisd2018";
            Connection = new SqlConnection(connetionString);
        }

        public SqlConnection Connection { get => connection; set => connection = value; }

        public string InsertRecordToDB(string query)
        {
            string result = "";
            try
            {
                Connection.Open();
                command = new SqlCommand(query, Connection);
                command.ExecuteNonQuery();                
                command.Dispose();
                result = "success";
                
            }
            catch (Exception NoResuslts)
            {                
                result = "Error occured : " + NoResuslts;
            }
            finally
            {
                Connection.Close();
            }
            return result;
        }
        public string UpdateRecordInDB(string query)
        {
            string result = "";
            try
            {
                Connection.Open();
                command = new SqlCommand(query, Connection);
                command.ExecuteNonQuery();
                command.Dispose();
                result = "success";

            }
            catch (Exception NoResuslts)
            {
                result = "Error occured : " + NoResuslts;
            }
            finally
            {
                Connection.Close();
            }
            return result;
        }


    }
}


