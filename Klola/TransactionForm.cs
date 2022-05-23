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

namespace Klola
{
    public partial class TransactionForm : Form
    {
        private int grandTotal;
        private int nRow = 0;
        DatabaseConnection connection = new DatabaseConnection();

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            initializeForm();
            getProductTable();
            getCategory();
        }

        private void initializeForm()
        {
            transactionDate.Text = DateTime.Today.ToShortDateString();
            sellerName.Text = getSellerName();
        }

        private string getSellerName()
        {
            SqlCommand command = new SqlCommand("SELECT SellerName FROM Seller WHERE SellerId LIKE 'S001'"
                , connection.getConnection());
            connection.openConnection();

            return command.ExecuteScalar().ToString();
        }

        private void getProductTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT ProductName, ProductPrice FROM Product", connection.getConnection()));
            DataTable table = new DataTable();
            adapter.Fill(table);
            productDataGrid.DataSource = table;
        }

        private void getCategory()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM Category", connection.getConnection()));
            DataTable table = new DataTable();
            adapter.Fill(table);
            categoryComboBox.DataSource = table;
            categoryComboBox.ValueMember = "CategoryName";
        }

        private void productDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                nameBox.Text = productDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                priceBox.Text = productDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception ex) { };
        }

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "SELECT ProductName, ProductPrice FROM Product JOIN Category ON " +
                "Category.CategoryId = Product.CategoryId WHERE Product.CategoryId LIKE '"
                + getCategoryId(categoryComboBox.SelectedValue.ToString()) + "'";
            SqlCommand command = new SqlCommand(query, connection.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            productDataGrid.DataSource = table;
        }

        public string getCategoryId(string name)
        {
            SqlCommand command = new SqlCommand("SELECT CategoryId FROM Category WHERE CategoryName LIKE '"
                + name + "'", connection.getConnection());
            connection.openConnection();

            return command.ExecuteScalar().ToString();
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || qtyBox.Text == "" || priceBox.Text == "")
            {
                MessageBox.Show("Informasi tidak lengkap!", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int totalPrice = Convert.ToInt32(priceBox.Text) * Convert.ToInt32(qtyBox.Text);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(transactionDataGrid);
                row.Cells[0].Value = ++nRow;
                row.Cells[1].Value = nameBox.Text;
                row.Cells[2].Value = priceBox.Text;
                row.Cells[3].Value = qtyBox.Text;
                row.Cells[4].Value = totalPrice;
                transactionDataGrid.Rows.Add(row);
                grandTotal += totalPrice;
                totalLabel.Text = "Rp. " + grandTotal;
            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            while (transactionDataGrid.Rows.Count != 0)
            {
                transactionDataGrid.Rows.RemoveAt(0); 
            }

            nRow = 0;
            grandTotal = 0;
            totalLabel.Text = "Rp. " + grandTotal;
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES('" + billBox.Text + "','" + DateTime.Today.Year + '-'
                    + DateTime.Today.Month + '-' + DateTime.Today.Day + "','" +
                    LoginForm.sellerId + "'," + grandTotal.ToString() + ")";
                SqlCommand command = new SqlCommand(insertQuery, connection.getConnection());
                connection.openConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Bill berhasil ditambahkan!", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
