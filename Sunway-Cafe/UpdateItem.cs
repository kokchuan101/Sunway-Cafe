using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunway_Cafe.Model;

namespace Sunway_Cafe
{
    public partial class UpdateItem : Form
    {

        private Image _image;
        public Image displayImage
        {
            get { return _image; }
            set { _image = value; pictureBox.Image = value; pictureBox.SizeMode = PictureBoxSizeMode.Zoom; }
        }


        public UpdateItem()
        {
            InitializeComponent();
            textBox1.Text = OrderOptions.selectItemName;
            pictureBox.Image = OrderOptions.selectedItemImage;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();              
            }
        }

        private async void update_Click(object sender, EventArgs e)
        {
            using (SunwayCafeContext db = new SunwayCafeContext())
            {
                if (OrderOptions.selectItemName != null)
                {
                    var item = db.ItemTestss.Where(d => d.Name == OrderOptions.selectItemName).First();
                    item.Name = textBox1.Text.Trim();
                    if (pictureBox.Image != OrderOptions.selectedItemImage)
                    {
                        item.ImageURL = ConvertImageToBinary(pictureBox.Image);
                    }
                    await db.SaveChangesAsync();
                    MessageBox.Show("Item Updated");
                }
            }     
        }

        private void open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename.Text = ofd.FileName;
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}
