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
        public EditProfilePage(Account editAccount)
        {
            InitializeComponent();
            textBoxs = new Dictionary<string, MetroSetTextBox>()
            {
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

   
                Global.user.ModifyEditDisplay(this);
            }


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {

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
                }
                Form profilePage = new ProfilePage();
                profilePage.Refresh();
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



            //if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text) ||  string.IsNullOrEmpty(familyName.Text) || string.IsNullOrEmpty(givenName.Text) || string.IsNullOrEmpty(contact.Text) || string.IsNullOrEmpty(email.Text))
            //{
            //    MessageBox.Show("Please enter all the fields");
            //    Close();
            //}
            //else
            //{
            //    editProfile.Enabled = true;
            //    if (editProfile.Text == "Add Staff")
            //    {
            //        try
            //        {
            //            using (var db = new SunwayCafeContext())
            //            {
            //                var lst = db.Accounts.ToList();

            //                var newStaff = new Account()
            //                {
            //                    Username = username.Text,
            //                    Password = password.Text,
            //                    Role = role.Text,
            //                    FamilyName = familyName.Text,
            //                    GivenName = givenName.Text,
            //                    Gender = gender.Text,
            //                    Contact = int.Parse(contact.Text),
            //                    Email = email.Text,
            //                };

            //                db.Accounts.Add(newStaff);
            //                db.SaveChanges();
            //            }
            //        }
            //        catch (InvalidCastException ice)
            //        {
            //            if (ice == null)
            //            {
            //                MessageBox.Show("Null Value Detected");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        try
            //        {
            //            using (var db = new SunwayCafeContext())
            //            {
            //                var query = db.Accounts.Where(acc => acc.Id == ID).FirstOrDefault();

            //                query.Username = username.Text;
            //                query.Password = password.Text;
            //                query.Role = role.Text;
            //                query.FamilyName = familyName.Text;
            //                query.GivenName = givenName.Text;
            //                query.Gender = gender.Text;
            //                query.Contact = int.Parse(contact.Text);
            //                query.Email = email.Text;
            //                db.SaveChanges();
            //            }
            //        }
            //        catch (InvalidCastException ice)
            //        {
            //            if (ice == null)
            //            {
            //                MessageBox.Show("Null Value Detected");
            //            }
            //        }
            //    }
            //}

        }

        private void contact_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(contact.Text, out int value) == false)
            {
                editProfile.Enabled = false;
                contact.Focus();
                errorProvider1.SetError(contact, "Please enter a username");
            }
            else
            {
                editProfile.Enabled = true;
                errorProvider1.SetError(contact, null);
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
