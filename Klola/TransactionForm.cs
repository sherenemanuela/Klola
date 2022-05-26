using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Klola
{
    public partial class TransactionForm : Klola.DatabaseManagementForm
    {
        private int grandTotal;
        private int nRow = 0;
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
            sellerName.Text = getDataString("SELECT SellerName FROM Seller WHERE SellerId LIKE '" + LoginForm.sellerId + "'");
        }

        private void getProductTable()
        {
            productDataGrid.DataSource = getDataTable("SELECT ProductName, ProductPrice FROM Product");
        }

        private void getCategory()
        {
            categoryComboBox.DataSource = getDataTable("SELECT * FROM Category");
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
            productDataGrid.DataSource = getDataTable(query);
        }

        public string getCategoryId(string name)
        {
            return getDataString("SELECT CategoryId FROM Category WHERE CategoryName LIKE '"
                + name + "'");
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            if (validateInputs())
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
            deleteTransaction();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateCheckout())
                {
                    string query = "INSERT INTO Bill VALUES('" + billBox.Text + "','" + DateTime.Today.Year + '-'
                        + DateTime.Today.Month + '-' + DateTime.Today.Day + "','" +
                        LoginForm.sellerId + "'," + grandTotal.ToString() + ")";
                    updateTable(query, "Transaksi berhasil ditambahkan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteTransaction()
        {
            while (transactionDataGrid.Rows.Count != 0)
            {
                transactionDataGrid.Rows.RemoveAt(0);
            }

            nRow = 0;
            grandTotal = 0;
            totalLabel.Text = "Rp. " + grandTotal;
        }

        private void updateTable(string query, string message)
        {
            updateData(query);
            MessageBox.Show(message, "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            deleteTransaction();
        }

        private Boolean isComplete()
        {
            if (categoryComboBox.SelectedIndex < 0 || nameBox.Text == "" || priceBox.Text == "" || qtyBox.Text == "")
                return false;
            return true;
        }

        private Boolean validateCategory()
        {
            if (categoryComboBox.SelectedIndex < 0)
            {
                return false;
            }
            return true;
        }

        private Boolean validateName()
        {
            if (nameBox.Text.Length < 3 || nameBox.Text.Length > 20)
            {
                return false;
            }
            return true;
        }

        private Boolean validatePrice()
        {
            try
            {
                if (Int32.Parse(priceBox.Text) < 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private Boolean validateQuantity()
        {
            try
            {
                if (Int32.Parse(qtyBox.Text) < 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private Boolean validateInputs()
        {
            if (!isComplete())
            {
                MessageBox.Show("Informasi tidak lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateName())
            {
                MessageBox.Show("Nama produk harus memiliki 3 - 20 karakter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateCategory())
            {
                MessageBox.Show("Kategori tidak boleh kosong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validatePrice())
            {
                MessageBox.Show("Harga produk harus berupa angka positif!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateQuantity())
            {
                MessageBox.Show("Jumlah produk harus berupa angka positif!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!productExist())
            {
                MessageBox.Show("Informasi produk tidak ada/sesuai!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private Boolean productExist()
        {
            if ((nameBox.Text == getDataString("SELECT productName FROM Product WHERE productName LIKE '"
                + nameBox.Text + "'")) && (priceBox.Text == getDataString("SELECT productPrice FROM Product " +
                "WHERE productName LIKE '" + nameBox.Text + "'")))
                return true;
            return false;
        }

        private Boolean validateCheckout()
        {
            if (billBox.Text.Length != 4 || billBox.Text.First() != 'B')
            {
                MessageBox.Show("ID bill harus terdiri dari huruf 'B' diikuti dengan 3 angka. Contoh : B001", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (transactionDataGrid.Rows.Count <= 0)
            {
                MessageBox.Show("Tidak ada produk untuk checkout!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
