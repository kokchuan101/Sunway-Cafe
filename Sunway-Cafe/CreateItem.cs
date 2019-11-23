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
using MetroSet_UI.Controls;
using Sunway_Cafe.Model;

namespace Sunway_Cafe
{
    public partial class CreateItem : Form
    {

        private Dictionary<string, MetroSetTextBox> textBoxs;
        public CreateItem()
        {
            InitializeComponent();
            textBoxs = new Dictionary<string, MetroSetTextBox>()
            {
                { "Name", textBox2},
                { "SellingPrice", priceBox},
                { "CostPrice", costPriceBox}
            };

            Image img = Properties.Resources.banana;
            pictureBox.Image = img;
        }



        private async void button1_Click_1(object sender, EventArgs e)
        {
            Global.ClearErrors(errorProvider1, textBoxs);
            var success = true;

            if(!decimal.TryParse(priceBox.Text.Trim(), out decimal priceVal))
            {
                errorProvider1.SetError(priceBox, "Numbers only.");
                success = false;
            }

            if (!decimal.TryParse(priceBox.Text.Trim(), out decimal costVal))
            {
                errorProvider1.SetError(costPriceBox, "Numbers only.");
                success = false;
            }

            if(String.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                errorProvider1.SetError(textBox2, "The Name field is required.");
                success = false;
            }
           
            using (SunwayCafeContext db = new SunwayCafeContext())
            {
                if (success)
                {
                    Item item = new Item()
                    {
                        Name = textBox2.Text.Trim(),
                        ImageURL = Global.ConvertImageToBinary(pictureBox.Image),
                        SellingPrice = priceVal,
                        CostPrice = costVal,
                        Type = Food.Checked? Food.Text: Drinks.Text
                    };
                    db.Items.Add(item);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Item Created");
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
