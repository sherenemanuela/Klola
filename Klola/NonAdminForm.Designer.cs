namespace Klola
{
    partial class NonAdminForm
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
            this.Riwayat = new FontAwesome.Sharp.IconButton();
            this.Transaksi = new FontAwesome.Sharp.IconButton();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.Transaksi);
            this.menuPanel.Controls.Add(this.Riwayat);
            this.menuPanel.Controls.SetChildIndex(this.Riwayat, 0);
            this.menuPanel.Controls.SetChildIndex(this.Transaksi, 0);
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
            this.Riwayat.Location = new System.Drawing.Point(-2, 279);
            this.Riwayat.Name = "Riwayat";
            this.Riwayat.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.Riwayat.Size = new System.Drawing.Size(247, 68);
            this.Riwayat.TabIndex = 21;
            this.Riwayat.Text = "Riwayat";
            this.Riwayat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Riwayat.UseVisualStyleBackColor = true;
            this.Riwayat.Click += new System.EventHandler(this.Riwayat_Click);
            // 
            // Transaksi
            // 
            this.Transaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transaksi.FlatAppearance.BorderSize = 0;
            this.Transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transaksi.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaksi.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.Transaksi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.Transaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Transaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transaksi.Location = new System.Drawing.Point(-2, 196);
            this.Transaksi.Name = "Transaksi";
            this.Transaksi.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.Transaksi.Size = new System.Drawing.Size(247, 68);
            this.Transaksi.TabIndex = 22;
            this.Transaksi.Text = "Transaksi";
            this.Transaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Transaksi.UseVisualStyleBackColor = true;
            this.Transaksi.Click += new System.EventHandler(this.Transaksi_Click);
            // 
            // NonAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Name = "NonAdminForm";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Riwayat;
        private FontAwesome.Sharp.IconButton Transaksi;
    }
}
