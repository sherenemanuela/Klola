namespace Klola
{
    partial class UserForm
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
            this.formPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.exitBtn);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.menuPanel.Location = new System.Drawing.Point(0, -24);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(247, 800);
            this.menuPanel.TabIndex = 2;
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
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.formPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.formPanel.Location = new System.Drawing.Point(244, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(956, 800);
            this.formPanel.TabIndex = 3;
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
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NonAdminForm";
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel formPanel;
        public System.Windows.Forms.Panel menuPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton exitBtn;
    }
}