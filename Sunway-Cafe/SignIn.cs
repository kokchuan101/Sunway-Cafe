using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunway_Cafe
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            Hide();
        }
    }
}
