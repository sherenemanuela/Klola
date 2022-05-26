using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Klola
{
    public partial class NonAdminForm : Klola.UserForm
    {
        public NonAdminForm()
        {
            InitializeComponent();
        }

        private void Transaksi_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openSelectedForm(new TransactionForm());
        }

        private void Riwayat_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openSelectedForm(new HistoryForm());
        }
    }
}
