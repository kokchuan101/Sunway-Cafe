using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunway_Cafe
{
    public partial class OrderOptions : UserControl
    {
        public OrderOptions()
        {
            InitializeComponent();
        }

        private string _name;

        public string Name_details
        {
            get { return _name; }
            set { _name = value;}
        }

        private int _id;

        private int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        }
}
