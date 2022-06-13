using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderBijdragen
{
    internal class Database
    {
        public static SqlConnection OpenSqlConnection()
        {
            SqlConnection connection = new SqlConnection(Constants.connectionString);
            connection.Open();

            return connection;
        }

        public static DataSet SelectDataFromDatabase(string query)
        {
            DataSet results = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, OpenSqlConnection());
            adapter.Fill(results);
            
            return results;
        }
    }
}
