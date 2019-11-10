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
        
        public OrderOptions()
        {
            InitializeComponent();
        }

        private string nameDetails;
        public event EventHandler<EventArgs> WasClicked;

     
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
