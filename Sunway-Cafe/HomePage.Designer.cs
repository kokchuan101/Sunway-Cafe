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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Order = new System.Windows.Forms.Button();
            this.Item = new System.Windows.Forms.Button();
            this.Manage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.Order);
            this.panel1.Controls.Add(this.Item);
            this.panel1.Controls.Add(this.Manage);
            this.panel1.Location = new System.Drawing.Point(32, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 459);
            this.panel1.TabIndex = 4;
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.SlateGray;
            this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.ForeColor = System.Drawing.Color.Black;
            this.Order.Image = ((System.Drawing.Image)(resources.GetObject("Order.Image")));
            this.Order.Location = new System.Drawing.Point(57, 44);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(203, 371);
            this.Order.TabIndex = 5;
            this.Order.Text = "Order";
            this.Order.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Order.UseVisualStyleBackColor = false;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // Item
            // 
            this.Item.BackColor = System.Drawing.Color.SlateGray;
            this.Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.ForeColor = System.Drawing.Color.Black;
            this.Item.Image = ((System.Drawing.Image)(resources.GetObject("Item.Image")));
            this.Item.Location = new System.Drawing.Point(764, 44);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(203, 371);
            this.Item.TabIndex = 7;
            this.Item.Text = "Item";
            this.Item.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Item.UseVisualStyleBackColor = false;
            this.Item.Click += new System.EventHandler(this.Item_Click_1);
            // 
            // Manage
            // 
            this.Manage.BackColor = System.Drawing.Color.SlateGray;
            this.Manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage.ForeColor = System.Drawing.Color.Black;
            this.Manage.Image = ((System.Drawing.Image)(resources.GetObject("Manage.Image")));
            this.Manage.Location = new System.Drawing.Point(413, 44);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(203, 371);
            this.Manage.TabIndex = 6;
            this.Manage.Text = "Manage";
            this.Manage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Manage.UseVisualStyleBackColor = false;
            this.Manage.Click += new System.EventHandler(this.Manage_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1086, 505);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button Item;
        private System.Windows.Forms.Button Manage;
    }
}
