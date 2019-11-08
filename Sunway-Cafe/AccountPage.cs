using Sunway_Cafe.Model;
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
    public partial class AccountPage : Form
    {
        public AccountPage()
        {
            InitializeComponent();
            ProfilePage profile = new ProfilePage();
            nav(profile, content);
            Global.user.ModifyDisplay(this);
        }

        public string Role { get; set; }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = profileBtn.Height;
            sidePanel.Top = profileBtn.Top;
            sidePanel.BringToFront();
            ProfilePage profile = new ProfilePage();
            nav(profile, content);
        }

        private void stockBtn_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = stockBtn.Height;
            sidePanel.Top = stockBtn.Top;
            sidePanel.BringToFront();
            StockPage stock = new StockPage();
            nav(stock, content);
        }

        public void nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form signIn = new SignInPage();
            this.Close();
            signIn.Show();
            Global.user = new User();
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = manageBtn.Height;
            sidePanel.Top = manageBtn.Top;
            sidePanel.BringToFront();
            ManagementPage manage = new ManagementPage();
            nav(manage, content);
        }
    }
}
