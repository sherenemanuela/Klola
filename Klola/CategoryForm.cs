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
    public partial class CategoryForm : KryptonForm
    {
        DatabaseConnection connection = new DatabaseConnection();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM Category", connection.getConnection()));
            DataTable table = new DataTable();
            adapter.Fill(table);
            categoryDataGrid.DataSource = table;
            styleTableHeader();
        }

        private void styleTableHeader()
        {
            categoryDataGrid.Columns[0].HeaderText = "ID Kategori";
            categoryDataGrid.Columns[1].HeaderText = "Nama Kategori";
            categoryDataGrid.Columns[2].HeaderText = "Deskripsi";
            categoryDataGrid.Columns[0].Width = 120;
            categoryDataGrid.Columns[1].Width = 180;
        }

        private Boolean isComplete()
        {
            if (idBox.Text == "" || nameBox.Text == "" || descriptionBox.Text == "")
                return false;
            return true;
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isComplete())
                {
                    MessageBox.Show("Informasi tidak lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "INSERT INTO Category VALUES('" + idBox.Text + "','" + nameBox.Text + "','"
                        + descriptionBox.Text + "')";
                    SqlCommand command = new SqlCommand(query, connection.getConnection());
                    connection.openConnection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kategori berhasil ditambahkan!", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void clear()
        {
            idBox.Clear();
            nameBox.Clear();
            descriptionBox.Clear();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void ubahBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isComplete())
                {
                    MessageBox.Show("Missing Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "UPDATE Category SET CategoryName='" + nameBox.Text + "', CategoryDescription='"
                        + descriptionBox.Text + "' WHERE CategoryId LIKE '" + idBox.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection.getConnection());
                    connection.openConnection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kategori berhasil diubah!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("ID kategori kosong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Category WHERE CategoryId LIKE '" + idBox.Text + "'";
                    SqlCommand command = new SqlCommand(deleteQuery, connection.getConnection());
                    connection.openConnection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kategori berhasil dihapus!", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void categoryDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                idBox.Text = categoryDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                nameBox.Text = categoryDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                descriptionBox.Text = categoryDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex) { };
        }
    }
}
