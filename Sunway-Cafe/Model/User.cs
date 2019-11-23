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

        public virtual void ModifyMainDisplay(MainPage form)
        { 
            
        }

        public virtual void ModifyHomeDisplay(HomePage form)
        {

        }


        public virtual void ModifyEditDisplay(EditProfilePage form)
        {

        }
    }

    public class Admin: User
    {
        public Admin(Account acc) : base(acc)
        {

        }

        public override void ModifyMainDisplay(MainPage form)
        {
            form.Account.Show();
            form.Item.Show();
            form.Stock.Show();
        }

        public override void ModifyHomeDisplay(HomePage form)
        {
            form.Account.Show();
            form.Item.Show();
            form.Stock.Show();
        }

        public override void ModifyEditDisplay(EditProfilePage form)
        {
            form.label6.Show();
            form.role.Show();
        }
    }

    public class SalesStaff: User
    {
        public SalesStaff(Account acc) : base(acc)
        {

        }

        public override void ModifyMainDisplay(MainPage form)
        {
            form.Account.Hide();
            form.Item.Hide();
            form.Stock.Hide();
        }

        public override void ModifyHomeDisplay(HomePage form)
        {
            form.Account.Hide();
            form.Item.Hide();
            form.Stock.Hide();
        }
        public override void ModifyEditDisplay(EditProfilePage form)
        {
            form.label6.Hide();
            form.role.Hide();
        }
    }


}
