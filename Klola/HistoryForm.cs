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
using DGVPrinterHelper;

namespace Klola
{
    public partial class HistoryForm : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        DGVPrinter printer = new DGVPrinter();

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            getTransactionTable();
        }

        private void getTransactionTable()
        {
            historyDataGrid.DataSource = connection.getDataTable("SELECT * FROM Bill");
        }

        private void eksporBtn_Click(object sender, EventArgs e)
        {
            printer.Title = "Klola Transaction History";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Klola Store Management System";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(historyDataGrid);
        }
    }
}
