using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;

namespace Klola
{
    public partial class ProductForm : KryptonForm
    {
        DatabaseConnection connection = new DatabaseConnection();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }

        private void getCategory()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM Category", connection.getConnection()));
            DataTable table = new DataTable();
            adapter.Fill(table);
            categoryComboBox.DataSource = table;
            categoryComboBox.ValueMember = "CategoryName";
        }

        private void getTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(
                "SELECT ProductId, ProductName, CategoryName, ProductPrice, ProductQty FROM Product " +
                "JOIN Category ON Product.CategoryId = Category.CategoryId", connection.getConnection()));
            DataTable table = new DataTable();
            adapter.Fill(table);
            productDataGrid.DataSource = table;
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Product VALUES" +
                    "('" + idBox.Text + "','" + nameBox.Text + "','" + getCategoryId(categoryComboBox.Text) + "'," +
                    priceBox.Text + "," + quantityBox.Text + ")";

                SqlCommand command = new SqlCommand(query, connection.getConnection());
                connection.openConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Produk berhasil ditambahkan!", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.closeConnection();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ubahBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (idBox.Text == "" || nameBox.Text == "" || quantityBox.Text == "" || priceBox.Text == "")
                {
                    MessageBox.Show("Informasi tidak lengkap!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query =
                        "UPDATE Product SET ProductName='" + nameBox.Text + "',ProductPrice=" + priceBox.Text
                        + ",ProductQty=" + quantityBox.Text + ",CategoryId='" + getCategoryId(categoryComboBox.Text) +
                        "'WHERE ProductId='" + idBox.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection.getConnection());
                    connection.openConnection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produk berhasil diperbarui!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string query = "DELETE FROM Product WHERE ProductId LIKE '" + idBox.Text + "'";
                    SqlCommand command = new SqlCommand(query, connection.getConnection());
                    connection.openConnection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produk berhasil dihapus!", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public string getCategoryId(string name)
        {
            SqlCommand command = new SqlCommand("SELECT CategoryId FROM Category WHERE CategoryName LIKE '"
                + name + "'", connection.getConnection());
            connection.openConnection();

            return command.ExecuteScalar().ToString();
        }

        private void clear()
        {
            idBox.Clear();
            nameBox.Clear();
            quantityBox.Clear();
            priceBox.Clear();
            categoryComboBox.SelectedIndex = 0;
        }

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "SELECT ProductId, ProductName, CategoryName, ProductPrice, ProductQty FROM Product " +
                "JOIN Category ON Product.CategoryId = Category.CategoryId WHERE CategoryName LIKE '" +
                categoryComboBox.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(query, connection.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            productDataGrid.DataSource = table;
        }

        private void productDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                idBox.Text = productDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                nameBox.Text = productDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                categoryComboBox.Text = productDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                priceBox.Text = productDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                quantityBox.Text = productDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            } catch { }
        }
    }
}
