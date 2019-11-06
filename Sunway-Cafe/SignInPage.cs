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
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            var Username = username.Text;
            var Password = password.Text;

            using (var db = new SunwayCafeContext())
            {
                var query = db.Accounts.Where(acc => acc.Username == Username && acc.Password == Password).Select(acc => acc.Role);
                //var Role = query.Role;
                if(query.Count() == 1)
                {
                    AccountPage account = new AccountPage();
                    account.Show();
                    this.Hide();
                }
                else
                {
                    //Form pd = new PromptDialog();
                    //pd.ShowDialog();
                    MessageBox.Show("Wrong");
                    
                }
            }
            
        }
    }
}
