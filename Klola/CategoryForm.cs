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
    public partial class CategoryForm : Klola.DatabaseManagementForm
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        protected void getTable()
        {
            categoryDataGrid.DataSource = getDataTable("SELECT * FROM Category");
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

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateInputs())
                {
                    string query = "INSERT INTO Category VALUES('" + idBox.Text + "','" + nameBox.Text + "','"
                        + descriptionBox.Text + "')";
                    updateTable(query, "Kategori berhasil ditambahkan!");
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
                    string query = "UPDATE Category SET CategoryName='" + nameBox.Text + "', CategoryDescription='"
                        + descriptionBox.Text + "' WHERE CategoryId LIKE '" + idBox.Text + "'";
                    updateTable(query, "Kategori berhasil diubah!");
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
                if (isComplete() || validateInputs())
                {
                    string query = "DELETE FROM Category WHERE CategoryId LIKE '" + idBox.Text + "'";
                    updateTable(query, "Kategori berhasil dihapus!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateTable(string query, string message)
        {
            updateData(query);
            MessageBox.Show(message, "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getTable();
            clear();
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

        private void clear()
        {
            idBox.Clear();
            nameBox.Clear();
            descriptionBox.Clear();
        }

        private Boolean isComplete()
        {
            if (idBox.Text == "" || nameBox.Text == "" || descriptionBox.Text == "")
                return false;
            return true;
        }

        private Boolean validateId()
        {
            if (idBox.Text.Length != 4 || idBox.Text.First() != 'C')
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

        private Boolean validateDescription()
        {
            if (descriptionBox.Text.Length < 5 || descriptionBox.Text.Length > 50)
            {
                return false;
            }
            return true;
        }

        private Boolean validateInputs()
        {
            if (!isComplete())
            {
                MessageBox.Show("Informasi tidak lengkap!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!validateId())
            {
                MessageBox.Show("ID kategori harus terdiri dari huruf 'C' diikuti dengan 3 angka. Contoh : C001", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateName())
            {
                MessageBox.Show("Nama kategori harus memiliki 3 - 20 karakter!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!validateDescription())
            {
                MessageBox.Show("Deskripsi kategori harus memiliki 5 - 50 karakter!", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
