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
    public partial class CreateItem : Form
    {


        public CreateItem()
        {
            InitializeComponent();           
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {                     
            using (SunwayCafeContext db = new SunwayCafeContext())
            {
                int priceVal = int.Parse(priceBox.Text.Trim());
                int quantityVal = int.Parse(quantityBox.Text.Trim());
                ItemTests item = new ItemTests() { Name = textBox2.Text.Trim(), ImageURL = ConvertImageToBinary(pictureBox.Image), Price = priceVal, Quantity = quantityVal };
                db.ItemTestss.Add(item);
                await db.SaveChangesAsync();
                MessageBox.Show("Item Created");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
