namespace Sunway_Cafe
{
    partial class HomePage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.order = new System.Windows.Forms.Button();
            this.kitchen = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.flowLayoutPanel1.Controls.Add(this.order);
            this.flowLayoutPanel1.Controls.Add(this.kitchen);
            this.flowLayoutPanel1.Controls.Add(this.account);
            this.flowLayoutPanel1.Controls.Add(this.item);
            this.flowLayoutPanel1.Controls.Add(this.stock);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 130);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(15, 10, 15, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1024, 261);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.SlateGray;
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.Black;
            this.order.Image = ((System.Drawing.Image)(resources.GetObject("order.Image")));
            this.order.Location = new System.Drawing.Point(5, 5);
            this.order.Margin = new System.Windows.Forms.Padding(5);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(194, 249);
            this.order.TabIndex = 5;
            this.order.Text = "Order";
            this.order.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.order.UseVisualStyleBackColor = false;
            this.order.Click += new System.EventHandler(this.Order_Click);
            // 
            // kitchen
            // 
            this.kitchen.BackColor = System.Drawing.Color.SlateGray;
            this.kitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchen.ForeColor = System.Drawing.Color.Black;
            this.kitchen.Image = ((System.Drawing.Image)(resources.GetObject("kitchen.Image")));
            this.kitchen.Location = new System.Drawing.Point(209, 5);
            this.kitchen.Margin = new System.Windows.Forms.Padding(5);
            this.kitchen.Name = "kitchen";
            this.kitchen.Size = new System.Drawing.Size(194, 249);
            this.kitchen.TabIndex = 10;
            this.kitchen.Text = "Kitchen";
            this.kitchen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kitchen.UseVisualStyleBackColor = false;
            this.kitchen.Click += new System.EventHandler(this.Kitchen_Click);
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.SlateGray;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.ForeColor = System.Drawing.Color.Black;
            this.account.Image = ((System.Drawing.Image)(resources.GetObject("account.Image")));
            this.account.Location = new System.Drawing.Point(413, 5);
            this.account.Margin = new System.Windows.Forms.Padding(5);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(194, 249);
            this.account.TabIndex = 6;
            this.account.Text = "Account";
            this.account.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.account.UseVisualStyleBackColor = false;
            this.account.Click += new System.EventHandler(this.Manage_Click_1);
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.SlateGray;
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.ForeColor = System.Drawing.Color.Black;
            this.item.Image = ((System.Drawing.Image)(resources.GetObject("item.Image")));
            this.item.Location = new System.Drawing.Point(617, 5);
            this.item.Margin = new System.Windows.Forms.Padding(5);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(194, 249);
            this.item.TabIndex = 7;
            this.item.Text = "Item";
            this.item.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.item.UseVisualStyleBackColor = false;
            this.item.Click += new System.EventHandler(this.Item_Click_1);
            // 
            // stock
            // 
            this.stock.BackColor = System.Drawing.Color.SlateGray;
            this.stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.Color.Black;
            this.stock.Image = ((System.Drawing.Image)(resources.GetObject("stock.Image")));
            this.stock.Location = new System.Drawing.Point(821, 5);
            this.stock.Margin = new System.Windows.Forms.Padding(5);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(194, 249);
            this.stock.TabIndex = 9;
            this.stock.Text = "Stock";
            this.stock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stock.UseVisualStyleBackColor = false;
            this.stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(32, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 484);
            this.panel1.TabIndex = 9;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1086, 543);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button item;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button stock;
        private System.Windows.Forms.Button kitchen;
        private System.Windows.Forms.Panel panel1;
    }
}
