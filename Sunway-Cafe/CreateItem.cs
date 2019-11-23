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
        public CreateItem(Item item)
        {
            InitializeComponent();
            textBoxs = new Dictionary<string, MetroSetTextBox>()
            {
                { "Name", textBox2},
                { "SellingPrice", priceBox},
                { "CostPrice", costPriceBox}
            };
            if (item == null)
            {
                Image img = Properties.Resources.No_Image;
                pictureBox.Image = img;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                button1.Text = "Update";
                pictureBox.Image = OrderOptions.selectedItemImage;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                priceBox.Text = OrderOptions.selectedItemPrice.ToString();
                costPriceBox.Text = OrderOptions.selectedItemCostPrice.ToString();
                textBox2.Text = OrderOptions.selectItemName;
            }

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

            if (button1.Text == "Create")
            {
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
            else if (button1.Text == "Update")
            {
                using (SunwayCafeContext db = new SunwayCafeContext())
                {
                    if (OrderOptions.selectItemName != null)
                    {
                        var item = db.Items.Where(d => d.Name == OrderOptions.selectItemName).First();
                        item.Name = textBox2.Text.Trim();
                        if (pictureBox.Image != OrderOptions.selectedItemImage)
                        {
                            item.ImageURL = Global.ConvertImageToBinary(pictureBox.Image);
                        }
                        item.CostPrice = int.Parse(costPriceBox.Text.ToString());
                        item.SellingPrice = int.Parse(priceBox.Text.ToString());
                        item.Type = type;
                        await db.SaveChangesAsync();
                        MessageBox.Show("Item Updated");
                    }
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
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg;*.jpeg;*.png", ValidateNames = true, Multiselect = false })
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
