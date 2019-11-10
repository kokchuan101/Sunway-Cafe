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
    public partial class ManagementPage : Form
    {
        public ManagementPage()
        {
            InitializeComponent();
            listView1.Items.Clear();
           
            //listView1.HideSelection = false;
            using (var db = new SunwayCafeContext())
            {

                var query = db.Accounts.Where(acc => acc.Role == "SalesStaff").ToList();

                foreach(var staffList in query)
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

        private void AddStaff_Click(object sender, EventArgs e)
        {
            EditProfilePage editProfile = new EditProfilePage(0);
            editProfile.Show();
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            var id = int.Parse(item.Text);
            EditProfilePage editProfile = new EditProfilePage(id);
            editProfile.Show();
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var db = new SunwayCafeContext())
                {
                    ListViewItem item = listView1.SelectedItems[0];
                    var id = int.Parse(item.Text);
                    var selected = db.Accounts.Where(acc => acc.Id == id).FirstOrDefault();
                    db.Accounts.Remove(selected);
                    db.SaveChanges();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

    }
}
