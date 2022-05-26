using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FontAwesome.Sharp;

namespace Klola
{
    public partial class UserForm : KryptonForm
    {
        protected IconButton activeButton;
        protected Panel activeBar;
        protected Form activeForm;

        public UserForm()
        {
            InitializeComponent();
            createActiveBar();
        }

        protected void createActiveBar()
        {
            activeBar = new Panel();
            activeBar.Size = new Size(10, 68);
            menuPanel.Controls.Add(activeBar);
        }

        protected void activateButton(object senderButton)
        {
            if (senderButton != null)
            {
                disableButton();
                activeButton = (IconButton)senderButton;
                activeBar.BackColor = Color.FromArgb(146, 186, 146);
                activeBar.Location = new Point(0, activeButton.Location.Y);
                activeBar.Visible = true;
                activeBar.BringToFront();
            }
        }

        protected void disableButton()
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.White;
                activeButton.TextAlign = ContentAlignment.MiddleLeft;
                activeButton.IconColor = Color.FromArgb(82, 94, 117);
                activeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                activeButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        protected void openSelectedForm(Form selectedForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = selectedForm;
            selectedForm.TopLevel = false;
            selectedForm.FormBorderStyle = FormBorderStyle.None;
            selectedForm.Dock = DockStyle.Fill;
            formPanel.Controls.Add(selectedForm);
            selectedForm.BringToFront();
            selectedForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
