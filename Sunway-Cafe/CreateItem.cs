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



        private async void button1_Click_1(object sender, EventArgs e)
        {                     
            using (SunwayCafeContext db = new SunwayCafeContext())
            {
                if (textBox2 != null || priceBox != null || quantityBox != null)
                {
                    int priceVal = int.Parse(priceBox.Text.Trim());
                    int quantityVal = int.Parse(quantityBox.Text.Trim());
                    ItemTests item = new ItemTests() { Name = textBox2.Text.Trim(), ImageURL = Global.ConvertImageToBinary(pictureBox.Image), Price = priceVal, Quantity = quantityVal };
                    db.ItemTestss.Add(item);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Item Created");
                }
                else
                {
                    MessageBox.Show("Please fill in all the information!");
                }
            }
            ItemPage ip = new ItemPage();
            ip.loadData();
            this.Close();
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
