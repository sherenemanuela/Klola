namespace Klola
{
    partial class ProductForm
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
            this.categoryComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.quantityBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.priceBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.hapusBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ubahBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tambahBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.idBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryComboBox.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuInner;
            this.categoryComboBox.DropDownWidth = 50;
            this.categoryComboBox.Location = new System.Drawing.Point(212, 220);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(220, 40);
            this.categoryComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.categoryComboBox.StateCommon.ComboBox.Border.Rounding = 20;
            this.categoryComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoryComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.categoryComboBox.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.categoryComboBox.TabIndex = 54;
            this.categoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.categoryComboBox_SelectionChangeCommitted);
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(663, 168);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(220, 40);
            this.quantityBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.quantityBox.StateCommon.Border.Rounding = 20;
            this.quantityBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantityBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.quantityBox.TabIndex = 53;
            this.quantityBox.Tag = "";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(663, 115);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(220, 40);
            this.priceBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.priceBox.StateCommon.Border.Rounding = 20;
            this.priceBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.priceBox.TabIndex = 52;
            this.priceBox.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "Kuantitas Produk";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 27);
            this.label6.TabIndex = 50;
            this.label6.Text = "Harga Produk";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.productDataGrid.Location = new System.Drawing.Point(43, 379);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.RowHeadersWidth = 51;
            this.productDataGrid.RowTemplate.Height = 24;
            this.productDataGrid.Size = new System.Drawing.Size(839, 331);
            this.productDataGrid.TabIndex = 49;
            this.productDataGrid.Click += new System.EventHandler(this.productDataGrid_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hapusBtn.Location = new System.Drawing.Point(727, 297);
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
            this.hapusBtn.TabIndex = 48;
            this.hapusBtn.Values.Text = "Hapus";
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // ubahBtn
            // 
            this.ubahBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubahBtn.Location = new System.Drawing.Point(542, 297);
            this.ubahBtn.Name = "ubahBtn";
            this.ubahBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.ubahBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.ubahBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ubahBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ubahBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ubahBtn.Size = new System.Drawing.Size(155, 45);
            this.ubahBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.ubahBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(186)))), ((int)(((byte)(146)))));
            this.ubahBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ubahBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ubahBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ubahBtn.StateCommon.Border.Rounding = 20;
            this.ubahBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ubahBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubahBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.ubahBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.ubahBtn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ubahBtn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ubahBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ubahBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.ubahBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(150)))), ((int)(((byte)(101)))));
            this.ubahBtn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ubahBtn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.ubahBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ubahBtn.TabIndex = 47;
            this.ubahBtn.Values.Text = "Ubah";
            this.ubahBtn.Click += new System.EventHandler(this.ubahBtn_Click);
            // 
            // tambahBtn
            // 
            this.tambahBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tambahBtn.Location = new System.Drawing.Point(356, 297);
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
            this.tambahBtn.TabIndex = 46;
            this.tambahBtn.Values.Text = "Tambahkan";
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 45;
            this.label4.Text = "Kategori";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(212, 168);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(220, 40);
            this.nameBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameBox.StateCommon.Border.Rounding = 20;
            this.nameBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.nameBox.TabIndex = 44;
            this.nameBox.Tag = "";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(212, 115);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(220, 40);
            this.idBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.idBox.StateCommon.Border.Rounding = 20;
            this.idBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.idBox.TabIndex = 43;
            this.idBox.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 27);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nama Produk";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID Produk";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 44);
            this.label1.TabIndex = 40;
            this.label1.Text = "Kelola Produk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(938, 753);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.ubahBtn);
            this.Controls.Add(this.tambahBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox categoryComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox quantityBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox priceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView productDataGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton hapusBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ubahBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton tambahBtn;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox idBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
