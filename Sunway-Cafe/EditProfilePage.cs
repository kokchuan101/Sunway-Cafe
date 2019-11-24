using MetroSet_UI.Controls;
using Sunway_Cafe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sunway_Cafe
{
    public partial class EditProfilePage : Form
    {

        private Dictionary<string, MetroSetTextBox> textBoxs;
        private int Id;
        private AccountPage accountPageRef = null;
        private ProfilePage profilePageRef = null; 
        public EditProfilePage(Account editAccount, AccountPage ap)
        {
            LoadData(editAccount);
            accountPageRef = ap;
        }

        public EditProfilePage(Account editAccount, ProfilePage pp)
        {
            LoadData(editAccount);
            profilePageRef = pp;
        }

        public void LoadData(Account editAccount)
        {
            InitializeComponent();
            textBoxs = new Dictionary<string, MetroSetTextBox>()
            {
                { "Username", username },
                { "Password", password },
                { "FamilyName", familyName},
                { "GivenName", givenName},
                { "Contact", contact},
                { "Email", email},
            };

            if (editAccount == null)
            {
                editProfile.Text = "Add Staff";
                role.SelectedItem = "SalesStaff";
                gender.SelectedItem = "Male";
            }
            else
            {
                username.Text = editAccount.Username;
                password.Text = editAccount.Password;
                role.Text = editAccount.Role;
                familyName.Text = editAccount.FamilyName;
                givenName.Text = editAccount.GivenName;
                gender.Text = editAccount.Gender;
                contact.Text = editAccount.Contact;
                email.Text = editAccount.Email;
                Id = editAccount.Id;

            }
            Global.user.ModifyEditDisplay(this);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            Global.ClearErrors(errorProvider1, textBoxs);
            var account = new Account()
            {
                Username = username.Text,
                Password = password.Text,
                Role = role.Text,
                FamilyName = familyName.Text,
                GivenName = givenName.Text,
                Gender = gender.Text,
                Contact = contact.Text,
                Email = email.Text,
            };

            List<List<string>> err;
            if (Global.IsValid<Account>(account, out err))
            {
                using (var db = new SunwayCafeContext())
                {
                    if (editProfile.Text == "Add Staff")
                    {

                        db.Accounts.Add(account);
                    }
                    else
                    {
                        var query = db.Accounts.Where(acc => acc.Id == Id).FirstOrDefault();

                        query.Username = account.Username;
                        query.Password = account.Password;
                        query.Role = account.Role;
                        query.FamilyName = account.FamilyName;
                        query.GivenName = account.GivenName;
                        query.Gender = account.Gender;
                        query.Contact = account.Contact;
                        query.Email = account.Email;

                      
                    }
                    db.SaveChanges();

                    if (accountPageRef == null)
                    {
                        var query = db.Accounts.Where(acc => acc.Id == Id).FirstOrDefault();
                        Global.user.Details = query;
                        profilePageRef.RefreshPage();
                    }
                    else
                    {
                        accountPageRef.RefreshListView();
                    }
                }
                
                this.Close();
            }
            else
            {
                foreach (var er in err)
                {
                    errorProvider1.SetError(textBoxs[er[0]], er[1]);
                    textBoxs[er[0]].BorderColor = Color.Red;
                }
            }



           

        }




        //private void username_Validating(object sender, CancelEventArgs e)
        //{
        //    if(string.IsNullOrEmpty(username.Text))
        //    {
        //        editProfile.Enabled = false;
        //        username.Focus();
        //        errorProvider1.SetError(username, "Please enter a username");
        //    }
        //    else
        //    {
        //        errorProvider1.SetError(username, null);
        //    }
        //}


    }
}
