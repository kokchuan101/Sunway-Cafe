using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Controls;
using Sunway_Cafe.Model;

namespace Sunway_Cafe
{
    public partial class StockCreate : Form
    {
        private Dictionary<string, MetroSetTextBox> textBoxs;
        private int Id;
        private StockPage stockPageRef;
        public StockCreate(Stock stock, StockPage sp)
        {
            InitializeComponent();
            stockPageRef = sp;
            textBoxs = new Dictionary<string, MetroSetTextBox>()
            {
                {"Name", name },
                {"Qty", quantity },
                {"CriticalLevel", criticalLevel},
            };

            if (stock == null)
            {
               
            }
            else
            {
                button1.Text = "Update";
                //Assign Type RadioButton
                if(stock.Type == ingredient.Text)
                {
                    ingredient.Checked = true;
                }
                else if(stock.Type == spice.Text)
                {
                    spice.Checked = true;
                }
                else if (stock.Type == others.Text)
                {
                    others.Checked = true;
                }

                //Assign Unit RadioButton
                if (stock.Unit == gram.Text)
                {
                    gram.Checked = true;
                }
                else if (stock.Unit == miliLiter.Text)
                {
                    miliLiter.Checked = true;
                }
                else if (stock.Unit == piece.Text)
                {
                    piece.Checked = true;
                }
                name.Text = stock.Name;
                quantity.Text = stock.Qty;
                criticalLevel.Text = stock.CriticalLevel;
                Id = stock.Id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.ClearErrors(errorProvider1, textBoxs);
            string stockType = string.Empty;
            string stockUnit = string.Empty;

            //Type RadioBUtton
            if (ingredient.Checked == true)
            {
                stockType = ingredient.Text;
            }
            else if (spice.Checked == true)
            {
                stockType = spice.Text;
            }
            else if (others.Checked == true)
            {
                stockType = others.Text;
            }

            //Unit RadioButton
            if (gram.Checked == true)
            {
                stockUnit = gram.Text;
            }
            else if (miliLiter.Checked == true)
            {
                stockUnit = miliLiter.Text;
            }
            else if (piece.Checked == true)
            {
                stockUnit = piece.Text;
            }

            var stock = new Stock()
            {
                Name = name.Text,
                Type = stockType,
                Qty = quantity.Text,
                Unit = stockUnit,
                CriticalLevel = criticalLevel.Text,
            };

            List<List<string>> err;
            if (Global.IsValid<Stock>(stock, out err))
            {
                using (var db = new SunwayCafeContext())
                {
                    if (button1.Text == "Update")
                    {
                        var query = db.Stocks.Where(acc => acc.Id == Id).FirstOrDefault();

                        query.Name = stock.Name;
                        query.Type = stock.Type;
                        query.Qty = stock.Qty;
                        query.Unit = stock.Unit;
                        query.CriticalLevel = stock.CriticalLevel;
                    }
                    else
                    {
                        db.Stocks.Add(stock);
                    }

                    db.SaveChanges();
                }
                stockPageRef.RefreshListView();
                this.Close();
            }
            else
            {
                foreach (var er in err)
                {
                    errorProvider1.SetError(textBoxs[er[0]], er[1]);
                    textBoxs[er[0]].BorderColor = Color.Red;
                }
            }

            
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }
    }
}
