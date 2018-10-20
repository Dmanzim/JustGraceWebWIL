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

        public string AddRecord(string query, List<string> data)
        {
            string compiledData = "('\" ";
            for (int i=0; i<data.Count-1; i++)
            {
                compiledData += data[i].ToString()+  "+ \"','\" + ";
            }
            compiledData += data[data.Count - 1];
            compiledData += "\"');";

            sql = query + compiledData;
            bool recordAdded;
            //try
            //{
            //    connection.Open();
            //    command = new SqlCommand(sql, connection);
            //    command.ExecuteScalar();
            //    command.Dispose();
            //    connection.Close();
            //    //if query works
            //    recordAdded = true;
            //}
            //catch (Exception NoResuslts)
            //{
            //    //if query does not
            //    recordAdded = false;
            //    Console.WriteLine("No result");
            //    Console.ReadKey();
            //}
            return sql;
        }
    }
}


