using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Klola
{
    public partial class DatabaseManagementForm : KryptonForm
    {
        private DatabaseConnection connection = new DatabaseConnection();

        public DatabaseManagementForm()
        {
            InitializeComponent();
        }

        public void updateData(string query)
        {
            SqlCommand command = new SqlCommand(query, connection.getConnection());
            connection.openConnection();
            command.ExecuteNonQuery();
            connection.closeConnection();
        }

        public DataTable getDataTable(string message)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(message, connection.getConnection()));
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string getDataString(string message)
        {
            SqlCommand command = new SqlCommand(message, connection.getConnection());
            connection.openConnection();

            return command.ExecuteScalar().ToString();
        }
    }
}
