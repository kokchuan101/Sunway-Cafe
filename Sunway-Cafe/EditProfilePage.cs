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
    public partial class EditProfilePage : Form
    {
        public static int ID;
        public EditProfilePage(int id)
        {
            InitializeComponent();
            if(id == 0)
            {
                editProfile.Text = "Add Staff";
                role.SelectedItem = "SalesStaff";
                gender.SelectedItem = "Male";
            } 
            else
            {
                using (var db = new SunwayCafeContext())
                {
                    var query = db.Accounts.Where(acc => acc.Id == id).ToList();

                    username.Text = query[0].Username;
                    password.Text = query[0].Password;
                    role.Text = query[0].Role;
                    familyName.Text = query[0].FamilyName;
                    givenName.Text = query[0].GivenName;
                    gender.Text = query[0].Gender;
                    contact.Text = query[0].Contact.ToString();
                    email.Text = query[0].Email;
                    ID = id;

                }
                Global.user.ModifyEditDisplay(this);
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(password.Text) ||  string.IsNullOrEmpty(familyName.Text) || string.IsNullOrEmpty(givenName.Text) || string.IsNullOrEmpty(contact.Text) || string.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("Please enter all the fields");
                Close();
            }
            else
            {
                editProfile.Enabled = true;
                if (editProfile.Text == "Add Staff")
                {
                    using (var db = new SunwayCafeContext())
                    {
                        var lst = db.Accounts.ToList();

                        var newStaff = new Account()
                        {
                            Username = username.Text,
                            Password = password.Text,
                            Role = role.Text,
                            FamilyName = familyName.Text,
                            GivenName = givenName.Text,
                            Gender = gender.Text,
                            Contact = int.Parse(contact.Text),
                            Email = email.Text,
                        };

                        db.Accounts.Add(newStaff);
                        db.SaveChanges();
                    }
                }
                else
                {
                    using (var db = new SunwayCafeContext())
                    {
                        var query = db.Accounts.Where(acc => acc.Id == ID).FirstOrDefault();

                        query.Username = username.Text;
                        query.Password = password.Text;
                        query.Role = role.Text;
                        query.FamilyName = familyName.Text;
                        query.GivenName = givenName.Text;
                        query.Gender = gender.Text;
                        query.Contact = int.Parse(contact.Text);
                        query.Email = email.Text;
                        db.SaveChanges();
                    }
                }
            }
            Form profilePage = new ProfilePage();
            profilePage.Refresh();
            this.Close();
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

        //private void password_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(password.Text))
        //    {
        //        editProfile.Enabled = false;
        //        password.Focus();
        //        errorProvider2.SetError(password, "Please enter a password");
        //    }
        //    else
        //    {
        //        errorProvider2.SetError(password, null);
        //    }
        //}

        //private void familyName_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(familyName.Text))
        //    {
        //        editProfile.Enabled = false;
        //        familyName.Focus();
        //        errorProvider3.SetError(familyName, "Please enter a Family Name");
        //    }
        //    else
        //    {
        //        errorProvider3.SetError(familyName, null);
        //    }
        //}

        //private void givenName_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(givenName.Text))
        //    {
        //        editProfile.Enabled = false;
        //        givenName.Focus();
        //        errorProvider4.SetError(givenName, "Please enter a Given Name");
        //    }
        //    else
        //    {
        //        errorProvider4.SetError(givenName, null);
        //    }
        //}

        //private void contact_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(contact.Text))
        //    {
        //        editProfile.Enabled = false;
        //        contact.Focus();
        //        errorProvider5.SetError(contact, "Please enter a contact");
        //    }
        //    else
        //    {
        //        errorProvider5.SetError(contact, null);
        //    }
        //}

        //private void email_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(email.Text))
        //    {
        //        editProfile.Enabled = false;
        //        email.Focus();
        //        errorProvider6.SetError(email, "Please enter a Email");
        //    }
        //    else
        //    {
        //        errorProvider6.SetError(email, null);
        //    }
        //}

    }
}
