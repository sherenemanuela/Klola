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
    public partial class SellerForm : KryptonForm
    {
        DatabaseConnection connection = new DatabaseConnection();
        public SellerForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM Seller", connection.getConnection()));
            DataTable table = new DataTable();
            adapter.Fill(table);
            sellerDataGrid.DataSource = table;
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void clear()
        {
            idBox.Clear();
            nameBox.Clear();
            ageBox.Clear();
            phoneBox.Clear();
            passwordBox.Clear();
            genderBox.SelectedIndex = 0;
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Seller VALUES('" + idBox.Text + "','" + nameBox.Text
                    + "','" + genderBox.Text + "'," + ageBox.Text + ",'" + phoneBox.Text + "','"
                    + passwordBox.Text + "')";
                SqlCommand command = new SqlCommand(query, connection.getConnection());
                connection.openConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Penjual berhasil ditambahkan!", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.closeConnection();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean isComplete()
        {
            if (idBox.Text == "" || nameBox.Text == "" || ageBox.Text == "" || phoneBox.Text == "" || genderBox.Text == "" || passwordBox.Text == "")
                return false;
            return true;
        }

        private void ubahBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isComplete())
                {
                    MessageBox.Show("Informasi tidak lengkap!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "UPDATE Seller SET SellerName='" + nameBox.Text + "',SellerGender='" + genderBox.Text +
                        "',SellerAge=" + ageBox.Text + ",SellerPhone='" + phoneBox.Text + "',SellerPassword='" + passwordBox.Text
                        + "'WHERE SellerId LIKE '" + idBox.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection.getConnection());
                    connection.openConnection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Penjual berhasil diperbarui!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.closeConnection();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (idBox.Text == "")
                {
                    MessageBox.Show("Informasi tidak lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "DELETE FROM Seller WHERE SellerId LIKE '" + idBox.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection.getConnection());
                    connection.openConnection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Penjual berhasil dihapus!", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.closeConnection();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void sellerDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                idBox.Text = sellerDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                nameBox.Text = sellerDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                genderBox.Text = sellerDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                ageBox.Text = sellerDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                phoneBox.Text = sellerDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                passwordBox.Text = sellerDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            } catch { }
        }
    }
}
