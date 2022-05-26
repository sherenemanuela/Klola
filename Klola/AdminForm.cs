using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Klola
{
    public partial class AdminForm : Klola.UserForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Kategori_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openSelectedForm(new CategoryForm());
        }

        private void Produk_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openSelectedForm(new ProductForm());
        }

        private void Penjual_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openSelectedForm(new SellerForm());
        }

        private void Riwayat_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openSelectedForm(new HistoryForm());
        }
    }
}