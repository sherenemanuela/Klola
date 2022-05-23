namespace Klola
{
    partial class AdminForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Riwayat = new FontAwesome.Sharp.IconButton();
            this.Penjual = new FontAwesome.Sharp.IconButton();
            this.Produk = new FontAwesome.Sharp.IconButton();
            this.Kategori = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.exitBtn);
            this.menuPanel.Controls.Add(this.Riwayat);
            this.menuPanel.Controls.Add(this.Penjual);
            this.menuPanel.Controls.Add(this.Produk);
            this.menuPanel.Controls.Add(this.Kategori);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Location = new System.Drawing.Point(0, -24);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(247, 800);
            this.menuPanel.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Location = new System.Drawing.Point(37, 701);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.exitBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.exitBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.exitBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.exitBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exitBtn.Size = new System.Drawing.Size(155, 45);
            this.exitBtn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.exitBtn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.exitBtn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.exitBtn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.exitBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exitBtn.StateCommon.Border.Rounding = 20;
            this.exitBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.exitBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.exitBtn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.exitBtn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.exitBtn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Values.Text = "Keluar";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Riwayat
            // 
            this.Riwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Riwayat.FlatAppearance.BorderSize = 0;
            this.Riwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Riwayat.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Riwayat.IconChar = FontAwesome.Sharp.IconChar.History;
            this.Riwayat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.Riwayat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Riwayat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Riwayat.Location = new System.Drawing.Point(-2, 447);
            this.Riwayat.Name = "Riwayat";
            this.Riwayat.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.Riwayat.Size = new System.Drawing.Size(247, 68);
            this.Riwayat.TabIndex = 5;
            this.Riwayat.Text = "Riwayat";
            this.Riwayat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Riwayat.UseVisualStyleBackColor = true;
            this.Riwayat.Click += new System.EventHandler(this.Riwayat_Click);
            // 
            // Penjual
            // 
            this.Penjual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Penjual.FlatAppearance.BorderSize = 0;
            this.Penjual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Penjual.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penjual.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.Penjual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.Penjual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Penjual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Penjual.Location = new System.Drawing.Point(-2, 364);
            this.Penjual.Name = "Penjual";
            this.Penjual.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.Penjual.Size = new System.Drawing.Size(247, 68);
            this.Penjual.TabIndex = 3;
            this.Penjual.Text = "Penjual";
            this.Penjual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Penjual.UseVisualStyleBackColor = true;
            this.Penjual.Click += new System.EventHandler(this.Penjual_Click);
            // 
            // Produk
            // 
            this.Produk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Produk.FlatAppearance.BorderSize = 0;
            this.Produk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Produk.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produk.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.Produk.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.Produk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Produk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Produk.Location = new System.Drawing.Point(-2, 279);
            this.Produk.Name = "Produk";
            this.Produk.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.Produk.Size = new System.Drawing.Size(247, 68);
            this.Produk.TabIndex = 2;
            this.Produk.Text = "Produk";
            this.Produk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Produk.UseVisualStyleBackColor = true;
            this.Produk.Click += new System.EventHandler(this.Produk_Click);
            // 
            // Kategori
            // 
            this.Kategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kategori.FlatAppearance.BorderSize = 0;
            this.Kategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kategori.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kategori.IconChar = FontAwesome.Sharp.IconChar.List;
            this.Kategori.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.Kategori.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Kategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kategori.Location = new System.Drawing.Point(-2, 196);
            this.Kategori.Name = "Kategori";
            this.Kategori.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.Kategori.Size = new System.Drawing.Size(247, 68);
            this.Kategori.TabIndex = 1;
            this.Kategori.Text = "Kategori";
            this.Kategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Kategori.UseVisualStyleBackColor = true;
            this.Kategori.Click += new System.EventHandler(this.Kategori_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Klola.Properties.Resources.Klola_logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.formPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.formPanel.Location = new System.Drawing.Point(244, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(956, 800);
            this.formPanel.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.menuPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private FontAwesome.Sharp.IconButton Riwayat;
        private FontAwesome.Sharp.IconButton Penjual;
        private FontAwesome.Sharp.IconButton Produk;
        private FontAwesome.Sharp.IconButton Kategori;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton exitBtn;
        private System.Windows.Forms.Panel formPanel;
    }
}