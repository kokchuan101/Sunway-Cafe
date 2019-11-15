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
            listView1.Items.Clear();
            RefreshListView();
            //listView1.HideSelection = false;
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            EditProfilePage editProfile = new EditProfilePage(null);
            editProfile.Show();
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            var id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            using(var db = new SunwayCafeContext())
            {
                var acc = db.Accounts.Where(x => x.Id == id).FirstOrDefault();
                if(acc != null)
                {
                    EditProfilePage editProfile = new EditProfilePage(acc);
                    editProfile.Show();

                }
                else
                {
                    MessageBox.Show("Unable to find account in database. Please contact administrator.");
                }
            }
            RefreshListView();
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SunwayCafeContext())
                    {
                        ListViewItem item = listView1.SelectedItems[0];
                        var id = int.Parse(item.Text);
                        var selected = db.Accounts.Where(acc => acc.Id == id).FirstOrDefault();
                        db.Accounts.Remove(selected);
                        db.SaveChanges();
                    }
                } catch (InvalidCastException ice)
                {
                    if(ice == null)
                    {
                        MessageBox.Show("Null Value Detected");
                    }
                }
                RefreshListView();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void RefreshListView()
        {
            try
            {
                using (var db = new SunwayCafeContext())
                {

                    var query = db.Accounts.ToList();

                    foreach (var staffList in query)
                    {
                        ListViewItem staff = new ListViewItem(staffList.Id.ToString());
                        staff.SubItems.Add(staffList.GivenName);
                        staff.SubItems.Add(staffList.FamilyName);
                        staff.SubItems.Add(staffList.Role);
                        staff.SubItems.Add(staffList.Gender);
                        staff.SubItems.Add(staffList.Contact.ToString());
                        staff.SubItems.Add(staffList.Email);

                        listView1.Items.Add(staff);
                    }

                }
                listView1.Items[0].Selected = true;
                listView1.Select();
            }
            catch (InvalidCastException ice)
            {
                if (ice == null)
                {
                    MessageBox.Show("Null Value Detected");
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
