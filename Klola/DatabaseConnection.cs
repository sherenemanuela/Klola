using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klola
{
    class DatabaseConnection
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\KlolaDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }

        private SqlConnection getConnection()
        {
            return connection;
        }

        public void updateData(string query)
        {
            SqlCommand command = new SqlCommand(query, getConnection());
            openConnection();
            command.ExecuteNonQuery();
            closeConnection();
        }

        public DataTable getDataTable(string message)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(message, getConnection()));
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string getDataString(string message)
        {
            SqlCommand command = new SqlCommand(message, getConnection());
            openConnection();

            return command.ExecuteScalar().ToString();
        }
    }
}
