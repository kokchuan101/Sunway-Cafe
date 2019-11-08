using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sunway_Cafe.Model
{

    public class User
    {
        public Account Details { get; set; }

        public User() { }
        public User(Account acc)
        {
            Details = acc;
        }

        public virtual void ModifyDisplay(AccountPage form)
        { 
            
        }
    }

    public class Admin: User
    {
        public Admin(Account acc) : base(acc)
        {

        }

        public override void ModifyDisplay(AccountPage form)
        {
            form.manageBtn.Show();
            form.profileBtn.Show();
            form.stockBtn.Show();
        }
    }

    public class SalesStaff: User
    {
        public SalesStaff(Account acc) : base(acc)
        {

        }

        public override void ModifyDisplay(AccountPage form)
        {
            form.manageBtn.Hide();
            form.profileBtn.Show();
            form.stockBtn.Show();
        }
    }


}
