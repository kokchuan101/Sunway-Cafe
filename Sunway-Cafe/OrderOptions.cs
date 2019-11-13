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

        public OrderOptions()
        {
            InitializeComponent();
        }

        public static string selectItemName;
        public static Image selectedItemImage;
        public static int selectedItemPrice;
        public static int selectedItemQuantity;

        private string nameDetails;
        
        public string Name_details
        {
            get { return nameDetails; }
            set { nameDetails = value; nameDet.Text = value; }
        }

        private int _id;
  
        public int ID
        {
            get { return _id; }
            set { _id = value; ID = 1; }
        }

        private Image _image;
        public Image  displayImage
        {
            get { return _image; }
            set { _image = value; pictureBox.Image = value; pictureBox.SizeMode = PictureBoxSizeMode.Zoom; }
        }

        private int _qty;

        public int QTY
        {
            get { return _qty; }
            set { _qty = value; quantity.Text = value.ToString(); }
        }

        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; price.Text = value.ToString(); }
        }

        byte [] ConvertImageToBinary(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        Image ConvertBinaryToImage(byte[]image)
        {
            using (MemoryStream ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }

        private void OrderOptions_Load(object sender, EventArgs e)
        {
            this.MouseClick += Control_MouseClick;

            foreach (Control control in Controls)
            {
               control.MouseClick += Control_MouseClick;
            }

        }

        private void Control_MouseClick(object sender,MouseEventArgs e)
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
            selectedItemQuantity = this.QTY;
           
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
