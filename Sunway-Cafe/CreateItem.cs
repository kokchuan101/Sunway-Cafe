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
            Image img = Properties.Resources.banana;
            pictureBox.Image = img;
        }



        private async void button1_Click_1(object sender, EventArgs e)
        {
            bool success;
            bool success2;
            string type;
            bool isChecked = Food.Checked;

            if (isChecked)
            {
                type = Food.Text;
            }
            else
            {
                type = Drinks.Text;
                isChecked = true;
            }

            using (SunwayCafeContext db = new SunwayCafeContext())
            {

                success = int.TryParse(priceBox.Text.Trim(), out int priceVal);                
                success2 = int.TryParse(costPriceBox.Text.Trim(), out int costVal);

                if (success && success2 && isChecked)
                {
                    Item item = new Item() { Name = textBox2.Text.Trim(), ImageURL = Global.ConvertImageToBinary(pictureBox.Image), SellingPrice = priceVal, CostPrice = costVal, Type = type };
                    db.Items.Add(item);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Item Created");
                }
                else
                {
                    MessageBox.Show("Please fill in all the information!");
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
