namespace Klola
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hapusBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.checkoutBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionDate = new System.Windows.Forms.Label();
            this.sellerName = new System.Windows.Forms.Label();
            this.billBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.qtyBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.transactionDataGrid = new System.Windows.Forms.DataGridView();
            this.tambahBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // hapusBtn
            // 
            this.hapusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hapusBtn.Location = new System.Drawing.Point(559, 677);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.hapusBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.hapusBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.hapusBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.hapusBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.hapusBtn.Size = new System.Drawing.Size(155, 45);
            this.hapusBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.hapusBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.hapusBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.hapusBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.hapusBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.hapusBtn.StateCommon.Border.Rounding = 20;
            this.hapusBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.hapusBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.hapusBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.hapusBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.hapusBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.hapusBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.hapusBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.hapusBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.hapusBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.hapusBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.hapusBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.hapusBtn.TabIndex = 88;
            this.hapusBtn.Values.Text = "Hapus";
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutBtn.Location = new System.Drawing.Point(733, 677);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.checkoutBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.checkoutBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.checkoutBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.checkoutBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkoutBtn.Size = new System.Drawing.Size(155, 45);
            this.checkoutBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.checkoutBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.checkoutBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.checkoutBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.checkoutBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkoutBtn.StateCommon.Border.Rounding = 20;
            this.checkoutBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.checkoutBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.checkoutBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.checkoutBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.checkoutBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.checkoutBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkoutBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.checkoutBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.checkoutBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.checkoutBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.checkoutBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.checkoutBtn.TabIndex = 87;
            this.checkoutBtn.Values.Text = "Checkout";
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.White;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(752, 630);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(63, 27);
            this.totalLabel.TabIndex = 86;
            this.totalLabel.Text = "Rp. 0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 630);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 27);
            this.label7.TabIndex = 85;
            this.label7.Text = "Grand Total :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 623);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 41);
            this.dataGridView1.TabIndex = 84;
            // 
            // transactionDate
            // 
            this.transactionDate.AutoSize = true;
            this.transactionDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDate.Location = new System.Drawing.Point(786, 380);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(102, 27);
            this.transactionDate.TabIndex = 83;
            this.transactionDate.Text = "24/12/12";
            this.transactionDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sellerName
            // 
            this.sellerName.AutoSize = true;
            this.sellerName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerName.Location = new System.Drawing.Point(415, 380);
            this.sellerName.Name = "sellerName";
            this.sellerName.Size = new System.Drawing.Size(102, 27);
            this.sellerName.TabIndex = 82;
            this.sellerName.Text = "Tae Moo";
            this.sellerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // billBox
            // 
            this.billBox.Location = new System.Drawing.Point(132, 374);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(109, 40);
            this.billBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.billBox.StateCommon.Border.Rounding = 20;
            this.billBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.billBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.billBox.TabIndex = 81;
            this.billBox.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 80;
            this.label3.Text = "Bill ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // productDataGrid
            // 
            this.productDataGrid.AllowUserToAddRows = false;
            this.productDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.productDataGrid.Location = new System.Drawing.Point(59, 108);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.RowHeadersWidth = 51;
            this.productDataGrid.RowTemplate.Height = 24;
            this.productDataGrid.Size = new System.Drawing.Size(341, 231);
            this.productDataGrid.TabIndex = 79;
            this.productDataGrid.Click += new System.EventHandler(this.productDataGrid_Click);
            // 
            // qtyBox
            // 
            this.qtyBox.Location = new System.Drawing.Point(590, 249);
            this.qtyBox.Name = "qtyBox";
            this.qtyBox.Size = new System.Drawing.Size(298, 40);
            this.qtyBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.qtyBox.StateCommon.Border.Rounding = 20;
            this.qtyBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qtyBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.qtyBox.TabIndex = 78;
            this.qtyBox.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 77;
            this.label2.Text = "Jumlah";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryComboBox.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuInner;
            this.categoryComboBox.DropDownWidth = 50;
            this.categoryComboBox.Location = new System.Drawing.Point(590, 105);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(298, 40);
            this.categoryComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.categoryComboBox.StateCommon.ComboBox.Border.Rounding = 20;
            this.categoryComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoryComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.categoryComboBox.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.categoryComboBox.TabIndex = 76;
            this.categoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.categoryComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 44);
            this.label1.TabIndex = 68;
            this.label1.Text = "Transaksi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // total
            // 
            this.total.HeaderText = "Total Price";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // name
            // 
            this.name.HeaderText = "Product Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(590, 201);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(298, 40);
            this.priceBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.priceBox.StateCommon.Border.Rounding = 20;
            this.priceBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.priceBox.TabIndex = 75;
            this.priceBox.Tag = "";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(590, 152);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(298, 40);
            this.nameBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameBox.StateCommon.Border.Rounding = 20;
            this.nameBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.nameBox.TabIndex = 74;
            this.nameBox.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 73;
            this.label5.Text = "Harga";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 72;
            this.label6.Text = "Nama";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // transactionDataGrid
            // 
            this.transactionDataGrid.AllowUserToAddRows = false;
            this.transactionDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transactionDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.transactionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.name,
            this.price,
            this.qty,
            this.total});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transactionDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.transactionDataGrid.Location = new System.Drawing.Point(59, 428);
            this.transactionDataGrid.Name = "transactionDataGrid";
            this.transactionDataGrid.RowHeadersWidth = 51;
            this.transactionDataGrid.RowTemplate.Height = 24;
            this.transactionDataGrid.Size = new System.Drawing.Size(829, 195);
            this.transactionDataGrid.TabIndex = 71;
            // 
            // tambahBtn
            // 
            this.tambahBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tambahBtn.Location = new System.Drawing.Point(733, 308);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.tambahBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.tambahBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.tambahBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.tambahBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tambahBtn.Size = new System.Drawing.Size(155, 45);
            this.tambahBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.tambahBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.tambahBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.tambahBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.tambahBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tambahBtn.StateCommon.Border.Rounding = 20;
            this.tambahBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.tambahBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.tambahBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.tambahBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.tambahBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.tambahBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tambahBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.tambahBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.tambahBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.tambahBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.tambahBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tambahBtn.TabIndex = 70;
            this.tambahBtn.Values.Text = "Tambahkan";
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 69;
            this.label4.Text = "Kategori";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(938, 753);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.transactionDate);
            this.Controls.Add(this.sellerName);
            this.Controls.Add(this.billBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.qtyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.transactionDataGrid);
            this.Controls.Add(this.tambahBtn);
            this.Controls.Add(this.label4);
            this.Name = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton hapusBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton checkoutBtn;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label transactionDate;
        private System.Windows.Forms.Label sellerName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox billBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView productDataGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox qtyBox;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox categoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox priceBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView transactionDataGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton tambahBtn;
        private System.Windows.Forms.Label label4;
    }
}
