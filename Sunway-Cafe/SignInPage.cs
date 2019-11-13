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
            using (var db = new SunwayCafeContext())
            {
                db.Accounts.ToList();
            }

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
<<<<<<< HEAD
                    

=======
>>>>>>> 846b590680dace2363efdb05ac6048e0affebb0e
                    if(query.Role == "Admin")
                    {
                        Global.user = new Admin(query);
                    }
                    else
                    {
                        Global.user = new SalesStaff(query);
                    }
<<<<<<< HEAD

                    
                    MessageBox.Show($"{Global.user.Details.GivenName} and {Global.user.Details.Role}");
=======
                    AccountPage account = new AccountPage();
                    account.Show();
>>>>>>> 846b590680dace2363efdb05ac6048e0affebb0e

                    AccountPage account = new AccountPage();
                    account.Show();
                    this.Hide();
                    //MessageBox.Show($"{Global.user.Details.GivenName} and {Global.user.Details.Role}");


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
