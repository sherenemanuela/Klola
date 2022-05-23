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
    public partial class LoginForm : KryptonForm
    {
        public static string sellerId;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            exitBtn.ForeColor = ColorTranslator.FromHtml("#444F63");
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.ForeColor = ColorTranslator.FromHtml("#525E75");
        }

        private void masukBtn_Click(object sender, EventArgs e)
        {
            if (!credentialsIsEmpty())
            {
                if (UserComboBox.SelectedItem.ToString() == "Admin" && isAdmin())
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else if (UserComboBox.SelectedItem.ToString() == "Seller" && isSeller())
                {
                    sellerId = usernameBox.Text;
                    NonAdminForm sellerForm = new NonAdminForm();
                    sellerForm.Show();
                    this.Hide();
                }
            }
        }

        private Boolean credentialsIsEmpty()
        {
            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Username dan password tidak boleh kosong!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (UserComboBox.SelectedIndex <= -1)
            {
                MessageBox.Show("Pilihan peran tidak boleh kosong!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                return false;
        }

        private Boolean isSeller()
        {
            DatabaseConnection connection = new DatabaseConnection();

            string selectQuery = "SELECT * FROM Seller WHERE SellerId LIKE'" + usernameBox.Text +
                "' AND SellerPassword LIKE '" + passwordBox.Text + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection.getConnection());

            DataTable table = new DataTable();
            adapter.Fill(table);


            if (table.Rows.Count > 0)
                return true;

            MessageBox.Show("Username atau password salah!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private Boolean isAdmin()
        {
            if (usernameBox.Text == "Admin" && passwordBox.Text == "Admin123")
                return true;

            MessageBox.Show("Username atau password salah!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
