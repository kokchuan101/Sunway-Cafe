namespace Sunway_Cafe
{
    partial class MainPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.stock = new System.Windows.Forms.Button();
            this.profile1 = new System.Windows.Forms.Button();
            this.kitchen = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.stock);
            this.panel1.Controls.Add(this.profile1);
            this.panel1.Controls.Add(this.kitchen);
            this.panel1.Controls.Add(this.item);
            this.panel1.Controls.Add(this.account);
            this.panel1.Controls.Add(this.order);
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 739);
            this.panel1.TabIndex = 0;
            // 
            // stock
            // 
            this.stock.FlatAppearance.BorderSize = 0;
            this.stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.Color.SeaShell;
            this.stock.Image = ((System.Drawing.Image)(resources.GetObject("stock.Image")));
            this.stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stock.Location = new System.Drawing.Point(12, 440);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(155, 54);
            this.stock.TabIndex = 8;
            this.stock.Text = "Stock";
            this.stock.UseVisualStyleBackColor = true;
            this.stock.Click += new System.EventHandler(this.stock_Click);
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.profile1.FlatAppearance.BorderSize = 0;
            this.profile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile1.ForeColor = System.Drawing.Color.Black;
            this.profile1.Image = ((System.Drawing.Image)(resources.GetObject("profile1.Image")));
            this.profile1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profile1.Location = new System.Drawing.Point(8, 664);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(147, 63);
            this.profile1.TabIndex = 9;
            this.profile1.Text = "     Profile";
            this.profile1.UseVisualStyleBackColor = false;
            this.profile1.Click += new System.EventHandler(this.profile1_Click);
            // 
            // kitchen
            // 
            this.kitchen.FlatAppearance.BorderSize = 0;
            this.kitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchen.ForeColor = System.Drawing.Color.SeaShell;
            this.kitchen.Image = ((System.Drawing.Image)(resources.GetObject("kitchen.Image")));
            this.kitchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitchen.Location = new System.Drawing.Point(12, 260);
            this.kitchen.Name = "kitchen";
            this.kitchen.Size = new System.Drawing.Size(169, 54);
            this.kitchen.TabIndex = 7;
            this.kitchen.Text = "Kitchen";
            this.kitchen.UseVisualStyleBackColor = true;
            this.kitchen.Click += new System.EventHandler(this.Kitchen_Click);
            // 
            // item
            // 
            this.item.FlatAppearance.BorderSize = 0;
            this.item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.ForeColor = System.Drawing.Color.SeaShell;
            this.item.Image = ((System.Drawing.Image)(resources.GetObject("item.Image")));
            this.item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.item.Location = new System.Drawing.Point(12, 380);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(143, 54);
            this.item.TabIndex = 6;
            this.item.Text = "Item";
            this.item.UseVisualStyleBackColor = true;
            this.item.Click += new System.EventHandler(this.item_Click);
            // 
            // account
            // 
            this.account.FlatAppearance.BorderSize = 0;
            this.account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.ForeColor = System.Drawing.Color.SeaShell;
            this.account.Image = ((System.Drawing.Image)(resources.GetObject("account.Image")));
            this.account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account.Location = new System.Drawing.Point(12, 320);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(148, 54);
            this.account.TabIndex = 4;
            this.account.Text = "     Account";
            this.account.UseVisualStyleBackColor = true;
            this.account.Click += new System.EventHandler(this.manage_Click);
            // 
            // order
            // 
            this.order.FlatAppearance.BorderSize = 0;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.SeaShell;
            this.order.Image = ((System.Drawing.Image)(resources.GetObject("order.Image")));
            this.order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order.Location = new System.Drawing.Point(12, 202);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(148, 54);
            this.order.TabIndex = 5;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.sidepanel.Location = new System.Drawing.Point(0, 142);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(13, 54);
            this.sidepanel.TabIndex = 3;
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.SeaShell;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(12, 142);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(148, 54);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(160, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 23);
            this.panel2.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(162, 141);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1129, 586);
            this.mainpanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Peru;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(160, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 167);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 23);
            this.title.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(194, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 141);
            this.panel4.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sunway_Cafe.Properties.Resources.image0;
            this.pictureBox2.Location = new System.Drawing.Point(8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.Black;
            this.logOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.Image")));
            this.logOutBtn.Location = new System.Drawing.Point(1221, 65);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(70, 63);
            this.logOutBtn.TabIndex = 14;
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 59);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 739);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunway Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button item;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button kitchen;
        private System.Windows.Forms.Button stock;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button profile1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label label1;
    }
}

