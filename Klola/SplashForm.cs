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

namespace Klola
{
    public partial class SplashForm : KryptonForm
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            loadTimer.Start();
        }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            innerBar.Width += 2;
            if (innerBar.Width >= 410)
            {
                hideSplashForm();
                showLoginForm();
            }
        }

        private void hideSplashForm()
        {
            loadTimer.Stop();
            this.Hide();
        }

        private void showLoginForm()
        {
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
