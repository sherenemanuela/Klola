using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Klola
{
    public partial class HistoryForm : Klola.DatabaseManagementForm
    {
        private DGVPrinter printer = new DGVPrinter();

        public HistoryForm()
        {
            InitializeComponent();
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        protected void getTable()
        {
            historyDataGrid.DataSource = getDataTable("SELECT * FROM Bill");
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
