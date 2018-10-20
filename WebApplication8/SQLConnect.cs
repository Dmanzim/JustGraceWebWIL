using System;
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
            connection = new SqlConnection(connetionString);
        }

        public string InsertRecordToDB(string query)
        {
            string result = "";
            try
            {
                connection.Open();
                command = new SqlCommand(query, connection);
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
                connection.Close();
            }
            return result;
        }
        public string UpdateRecordInDB(string query)
        {
            string result = "";
            try
            {
                connection.Open();
                command = new SqlCommand(query, connection);
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
                connection.Close();
            }
            return result;
        }


    }
}


