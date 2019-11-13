using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunway_Cafe.Model;

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
            using (var db = new SunwayCafeContext())
            {
                var query = db.Accounts.Where(acc => acc.Username == username.Text && acc.Password == password.Text).FirstOrDefault();
                if(query != null)
                {
                    

                    if(query.Role == "Admin")
                    {
                        Global.user = new Admin(query);
                    }
                    else
                    {
                        Global.user = new SalesStaff(query);
                    }

                    
                    MessageBox.Show($"{Global.user.Details.GivenName} and {Global.user.Details.Role}");

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
