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

        private ItemPage itemPageRef;
        private Dictionary<string, MetroSetTextBox> textBoxs;
        public CreateItem(Item item, ItemPage ip)
        {
            InitializeComponent();
            itemPageRef = ip;
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



        private void button1_Click_1(object sender, EventArgs e)
        {
            Global.ClearErrors(errorProvider1, textBoxs);
            var success = true;

            if(!decimal.TryParse(priceBox.Text.Trim(), out decimal priceVal))
            {
                errorProvider1.SetError(priceBox, "Numbers only.");
                priceBox.BorderColor = Color.Red;
                success = false;
            }

            if (!decimal.TryParse(costPriceBox.Text.Trim(), out decimal costVal))
            {
                errorProvider1.SetError(costPriceBox, "Numbers only.");
                costPriceBox.BorderColor = Color.Red;
                success = false;
            }

            if (String.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                errorProvider1.SetError(textBox2, "The Name field is required.");
                textBox2.BorderColor = Color.Red;
                success = false;
            }

            var msg = string.Empty;
            using (SunwayCafeContext db = new SunwayCafeContext())
            {
                if (success)
                {

                    if (button1.Text == "Create")
                    {
                        Item item = new Item()
                        {
                            Name = textBox2.Text.Trim(),
                            ImageURL = Global.ConvertImageToBinary(pictureBox.Image),
                            SellingPrice = priceVal,
                            CostPrice = costVal,
                            Type = Food.Checked ? Food.Text : Drinks.Text
                        };
                        db.Items.Add(item);
                        msg = "Item Created";
                    }
                    else
                    {
                        
                        if (OrderOptions.selectItemName != null)
                        {
                            var item = db.Items.Where(d => d.Name == OrderOptions.selectItemName).First();
                            item.Name = textBox2.Text.Trim();
                            if (pictureBox.Image != OrderOptions.selectedItemImage)
                            {
                                item.ImageURL = Global.ConvertImageToBinary(pictureBox.Image);
                            }
                            item.SellingPrice = priceVal;
                            item.CostPrice = costVal;
                            item.Type = Food.Checked ? Food.Text : Drinks.Text;
                            msg = "Item Updated";
                        }
                        
                    }

                    db.SaveChanges();
                    MessageBox.Show(msg);
                    itemPageRef.loadData();
                    this.Close();
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
