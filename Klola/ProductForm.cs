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
    public partial class ProductForm : Klola.DatabaseManagementForm
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateInputs())
                {
                    string query = "INSERT INTO Product VALUES" +
                        "('" + idBox.Text + "','" + nameBox.Text + "','" + getCategoryId(categoryComboBox.Text) + "'," +
                        priceBox.Text + "," + quantityBox.Text + ")";

                    updateTable(query, "Produk berhasil ditambahkan!");
                }
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
                if (validateInputs())
                {
                    string query =
                        "UPDATE Product SET ProductName='" + nameBox.Text + "',ProductPrice=" + priceBox.Text
                        + ",ProductQty=" + quantityBox.Text + ",CategoryId='" + getCategoryId(categoryComboBox.Text) +
                        "'WHERE ProductId='" + idBox.Text + "'";
                    updateTable(query, "Produk berhasil diubah!");
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
                    updateTable(query, "Produk berhasil dihapus!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getCategoryId(string name)
        {
            return getDataString("SELECT CategoryId FROM Category WHERE CategoryName LIKE '"
                + name + "'");
        }

        private void updateTable(string query, string message)
        {
            updateData(query);
            MessageBox.Show(message, "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getTable();
            clear();
        }

        private void clear()
        {
            idBox.Clear();
            nameBox.Clear();
            quantityBox.Clear();
            priceBox.Clear();
            categoryComboBox.SelectedIndex = 0;
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
            }
            catch { }
        }

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "SELECT ProductId, ProductName, CategoryName, ProductPrice, ProductQty FROM Product " +
               "JOIN Category ON Product.CategoryId = Category.CategoryId WHERE CategoryName LIKE '" +
               categoryComboBox.SelectedValue.ToString() + "'";
            productDataGrid.DataSource = getDataTable(query);
        }

       

        private void getCategory()
        {
            categoryComboBox.DataSource = getDataTable("SELECT * FROM Category");
            categoryComboBox.ValueMember = "CategoryName";
        }

        private void getTable()
        {
            string query = "SELECT ProductId, ProductName, CategoryName, ProductPrice, ProductQty FROM Product " +
                            "JOIN Category ON Product.CategoryId = Category.CategoryId";
            productDataGrid.DataSource = getDataTable(query);
        }

        private Boolean isComplete()
        {
            if (idBox.Text == "" || nameBox.Text == "" || priceBox.Text == "" || quantityBox.Text == "")
                return false;
            return true;
        }

        private Boolean validateId()
        {
            if (idBox.Text.Length != 4 || idBox.Text.First() != 'P')
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

        private Boolean validateCategory()
        {
            if (categoryComboBox.SelectedIndex < 0)
            {
                return false;
            }
            return true;
        }

        private Boolean validatePrice()
        {
            if (Int32.Parse(priceBox.Text) < 0)
            {
                return false;
            }
            return true;
        }

        private Boolean validateQuantity()
        {
            if (Int32.Parse(quantityBox.Text) < 0)
            {
                return false;
            }
            return true;
        }

        private Boolean validateInputs()
        {
            if (!isComplete())
            {
                MessageBox.Show("Informasi tidak lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateId())
            {
                MessageBox.Show("ID produk harus terdiri dari huruf 'P' diikuti dengan 3 angka. Contoh : P001", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateName())
            {
                MessageBox.Show("Nama produk harus memiliki 3 - 20 karakter!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateCategory())
            {
                MessageBox.Show("Kategori tidak boleh kosong!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validatePrice())
            {
                MessageBox.Show("Harga produk tidak boleh negatif!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateQuantity())
            {
                MessageBox.Show("Jumlah produk tidak boleh negatif!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        
    }
}
