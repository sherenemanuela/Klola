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
    public partial class SellerForm : Klola.DatabaseManagementForm
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            sellerDataGrid.DataSource = getDataTable("SELECT * FROM SELLER");
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateInputs())
                {
                    string query = "INSERT INTO Seller VALUES('" + idBox.Text + "','" + nameBox.Text
                        + "','" + genderBox.Text + "'," + ageBox.Text + ",'" + phoneBox.Text + "','"
                        + passwordBox.Text + "')";
                    updateTable(query, "Penjual berhasil ditambahkan!");
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
                    string query = "UPDATE Seller SET SellerName='" + nameBox.Text + "',SellerGender='" + genderBox.Text +
                        "',SellerAge=" + ageBox.Text + ",SellerPhone='" + phoneBox.Text + "',SellerPassword='" + passwordBox.Text
                        + "'WHERE SellerId LIKE '" + idBox.Text + "'";
                    updateTable(query, "Penjual berhasil diubah!");
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
                    updateTable(query, "Penjual berhasil dihapus!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            ageBox.Clear();
            phoneBox.Clear();
            passwordBox.Clear();
            genderBox.SelectedIndex = 0;
        }

        private void genderBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Seller WHERE SellerGender LIKE '" +
               genderBox.SelectedItem.ToString() + "'";
            sellerDataGrid.DataSource = getDataTable(query);
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
            }
            catch { }
        }

        private Boolean isComplete()
        {
            if (idBox.Text == "" || nameBox.Text == "" || ageBox.Text == "" || phoneBox.Text == "" || genderBox.Text == "" || passwordBox.Text == "")
                return false;
            return true;
        }
        private Boolean validateId()
        {
            if (idBox.Text.Length != 4 || idBox.Text.First() != 'S')
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

        private Boolean validateGender()
        {
            if (genderBox.SelectedIndex < 0)
            {
                return false;
            }
            return true;
        }

        private Boolean validateAge()
        {
            if (Int32.Parse(ageBox.Text) < 17)
            {
                return false;
            }
            return true;
        }

        private Boolean validatePhone()
        {
            if (phoneBox.Text.Length > 13)
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
                MessageBox.Show("ID penjual harus terdiri dari huruf 'S' diikuti dengan 3 angka. Contoh : S001", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateName())
            {
                MessageBox.Show("Nama penjual harus memiliki 3 - 20 karakter!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateGender())
            {
                MessageBox.Show("Jenis kelamin penjual tidak boleh kosong!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateAge())
            {
                MessageBox.Show("Umur penjual harus lebih dari 17!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validatePhone())
            {
                MessageBox.Show("Nomor telepon penjual tidak boleh memiliki lebih dari 13 digit angka!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
