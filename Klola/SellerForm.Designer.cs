namespace Klola
{
    partial class SellerForm
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
            this.passwordBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genderBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.phoneBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ageBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sellerDataGrid = new System.Windows.Forms.DataGridView();
            this.hapusBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ubahBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tambahBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.idBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(663, 220);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(220, 40);
            this.passwordBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordBox.StateCommon.Border.Rounding = 20;
            this.passwordBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.passwordBox.TabIndex = 73;
            this.passwordBox.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 27);
            this.label7.TabIndex = 72;
            this.label7.Text = "Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // genderBox
            // 
            this.genderBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderBox.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuInner;
            this.genderBox.DropDownWidth = 50;
            this.genderBox.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.genderBox.Location = new System.Drawing.Point(219, 221);
            this.genderBox.Margin = new System.Windows.Forms.Padding(0);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(220, 40);
            this.genderBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.genderBox.StateCommon.ComboBox.Border.Rounding = 20;
            this.genderBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genderBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.genderBox.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.genderBox.TabIndex = 71;
            this.genderBox.SelectionChangeCommitted += new System.EventHandler(this.genderBox_SelectionChangeCommitted);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(663, 168);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(220, 40);
            this.phoneBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.phoneBox.StateCommon.Border.Rounding = 20;
            this.phoneBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.phoneBox.TabIndex = 70;
            this.phoneBox.Tag = "";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(663, 115);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(220, 40);
            this.ageBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ageBox.StateCommon.Border.Rounding = 20;
            this.ageBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ageBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.ageBox.TabIndex = 69;
            this.ageBox.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 27);
            this.label5.TabIndex = 68;
            this.label5.Text = "Nomor Telepon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 27);
            this.label6.TabIndex = 67;
            this.label6.Text = "Umur";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sellerDataGrid
            // 
            this.sellerDataGrid.AllowUserToAddRows = false;
            this.sellerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellerDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sellerDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellerDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sellerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellerDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.sellerDataGrid.Location = new System.Drawing.Point(43, 379);
            this.sellerDataGrid.Name = "sellerDataGrid";
            this.sellerDataGrid.RowHeadersWidth = 51;
            this.sellerDataGrid.RowTemplate.Height = 24;
            this.sellerDataGrid.Size = new System.Drawing.Size(839, 331);
            this.sellerDataGrid.TabIndex = 66;
            this.sellerDataGrid.Click += new System.EventHandler(this.sellerDataGrid_Click);
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
            this.hapusBtn.TabIndex = 65;
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
            this.ubahBtn.TabIndex = 64;
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
            this.tambahBtn.TabIndex = 63;
            this.tambahBtn.Values.Text = "Tambahkan";
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 27);
            this.label4.TabIndex = 62;
            this.label4.Text = "Jenis Kelamin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(219, 168);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(220, 40);
            this.nameBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameBox.StateCommon.Border.Rounding = 20;
            this.nameBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.nameBox.TabIndex = 61;
            this.nameBox.Tag = "";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(219, 115);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(220, 40);
            this.idBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.idBox.StateCommon.Border.Rounding = 20;
            this.idBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.idBox.TabIndex = 60;
            this.idBox.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 27);
            this.label3.TabIndex = 59;
            this.label3.Text = "Nama Lengkap";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID Karyawan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 44);
            this.label1.TabIndex = 57;
            this.label1.Text = "Kelola Karyawan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(938, 753);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sellerDataGrid);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.ubahBtn);
            this.Controls.Add(this.tambahBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordBox;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox genderBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox phoneBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ageBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView sellerDataGrid;
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
