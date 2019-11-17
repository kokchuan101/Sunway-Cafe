using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunway_Cafe.Model;
using System.IO;

namespace Sunway_Cafe
{
    public partial class OrderOptions : UserControl
    {
        public event EventHandler<EventArgs> WasClicked;       
       

        //access datagridview in orderpage
        public OrderOptions(OrderPage ordP)
        {
            InitializeComponent();
            this.orderPage = ordP;
        }

        //access controls in itempage
        public OrderOptions(ItemPage itmP)
        {
            InitializeComponent();
            this.itemPage = itmP;
        }

        public Item item;
        OrderPage orderPage;
        ItemPage itemPage;
        public static string selectItemName;
        public static Image selectedItemImage;
        public static int selectedItemPrice;
        public static int selectedItemQuantity;
        public bool firstTime = true;

        private string nameDetails;
        public string Name_details
        {
            get { return nameDetails; }
            set { nameDetails = value; nameDet.Text = value; }
        }

 
        private Image _image;
        public Image  displayImage
        {
            get { return _image; }
            set { _image = value; pictureBox.Image = value; pictureBox.SizeMode = PictureBoxSizeMode.Zoom; }
        }

       

        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; price.Text = value.ToString(); }
        }

        private void OrderOptions_Load(object sender, EventArgs e)
        {           
            foreach (Control control in Controls)
            {
               control.MouseClick += Control_MouseClick;
            }
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            var wasClicked = WasClicked;
            if (wasClicked != null)
            {
                WasClicked(this, EventArgs.Empty);
            }
            IsSelected = true;
            selectItemName = this.Name_details;
            selectedItemImage = this.displayImage;
            selectedItemPrice = this.Price;
            
            bool update = false;

            //Execute the codes below when OrderOption(OrderPage) constructor invoked
            if (orderPage != null)
            {
                foreach (DataGridViewRow row in orderPage.DataGridView1.Rows)
                {
                    var quantity = (Convert.ToInt32(row.Cells[orderPage.DataGridView1.Columns["Quantity"].Index].Value));

                    //Check if there is any row exist in datagridview1 to prevent null exception
                    if (row.Cells["Product"].Value != null)
                    {
                        if (firstTime == false)
                        {
                            if (row.Cells["Product"].Value.ToString() == selectItemName)
                            {
                                quantity++;
                                row.Cells["Quantity"].Value = quantity;
                                update = true;
                                orderPage.Total();
                                break;
                            }
                        }
                    }
                }

                if (update == false)
                {
                    orderPage.DataGridView1.Rows.Add(selectItemName, selectedItemPrice, 1, "+", "-");
                    orderPage.Total();
                    firstTime = false;
                }

                //UserControl click animation
                Task.Delay(20).Wait();
                IsSelected = false;
                wasClicked = null;
            }
        }

        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                this.BorderStyle = IsSelected ? BorderStyle.Fixed3D : BorderStyle.None;
            }
        }

       
    }
}
