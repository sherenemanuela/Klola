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
            this.Kategori = new FontAwesome.Sharp.IconButton();
            this.Riwayat = new FontAwesome.Sharp.IconButton();
            this.Produk = new FontAwesome.Sharp.IconButton();
            this.Penjual = new FontAwesome.Sharp.IconButton();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.Penjual);
            this.menuPanel.Controls.Add(this.Produk);
            this.menuPanel.Controls.Add(this.Kategori);
            this.menuPanel.Controls.Add(this.Riwayat);
            this.menuPanel.Controls.SetChildIndex(this.activeBar, 0);
            this.menuPanel.Controls.SetChildIndex(this.Riwayat, 0);
            this.menuPanel.Controls.SetChildIndex(this.Kategori, 0);
            this.menuPanel.Controls.SetChildIndex(this.Produk, 0);
            this.menuPanel.Controls.SetChildIndex(this.Penjual, 0);
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
            this.Kategori.TabIndex = 24;
            this.Kategori.Text = "Kategori";
            this.Kategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Kategori.UseVisualStyleBackColor = true;
            this.Kategori.Click += new System.EventHandler(this.Kategori_Click);
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
            this.Riwayat.Location = new System.Drawing.Point(0, 445);
            this.Riwayat.Name = "Riwayat";
            this.Riwayat.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.Riwayat.Size = new System.Drawing.Size(247, 68);
            this.Riwayat.TabIndex = 23;
            this.Riwayat.Text = "Riwayat";
            this.Riwayat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Riwayat.UseVisualStyleBackColor = true;
            this.Riwayat.Click += new System.EventHandler(this.Riwayat_Click);
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
            this.Produk.TabIndex = 25;
            this.Produk.Text = "Produk";
            this.Produk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Produk.UseVisualStyleBackColor = true;
            this.Produk.Click += new System.EventHandler(this.Produk_Click);
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
            this.Penjual.Location = new System.Drawing.Point(0, 362);
            this.Penjual.Name = "Penjual";
            this.Penjual.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.Penjual.Size = new System.Drawing.Size(247, 68);
            this.Penjual.TabIndex = 26;
            this.Penjual.Text = "Penjual";
            this.Penjual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Penjual.UseVisualStyleBackColor = true;
            this.Penjual.Click += new System.EventHandler(this.Penjual_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Name = "AdminForm";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Kategori;
        private FontAwesome.Sharp.IconButton Riwayat;
        private FontAwesome.Sharp.IconButton Produk;
        private FontAwesome.Sharp.IconButton Penjual;
    }
}
