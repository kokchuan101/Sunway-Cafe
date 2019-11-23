namespace Sunway_Cafe
{
    partial class OrderPage
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
            this.components = new System.ComponentModel.Container();
            this.Clear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Drinks = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Food = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deduct1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Clear1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Pay = new MetroSet_UI.Controls.MetroSetButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Drinks.SuspendLayout();
            this.Food.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.HeaderText = "";
            this.Clear.Name = "Clear";
            this.Clear.Width = 60;
            // 
            // Add
            // 
            this.Add.HeaderText = "";
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.Width = 40;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 70;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 70;
            // 
            // Product
            // 
            this.Product.HeaderText = "Name";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.Width = 130;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(718, 489);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 24);
            this.lbltotal.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total:";
            // 
            // Drinks
            // 
            this.Drinks.Controls.Add(this.flowLayoutPanel2);
            this.Drinks.Location = new System.Drawing.Point(4, 25);
            this.Drinks.Name = "Drinks";
            this.Drinks.Padding = new System.Windows.Forms.Padding(3);
            this.Drinks.Size = new System.Drawing.Size(576, 460);
            this.Drinks.TabIndex = 1;
            this.Drinks.Text = "Drinks";
            this.Drinks.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 17);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(533, 437);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // Food
            // 
            this.Food.Controls.Add(this.flowLayoutPanel1);
            this.Food.Location = new System.Drawing.Point(4, 25);
            this.Food.Name = "Food";
            this.Food.Padding = new System.Windows.Forms.Padding(3);
            this.Food.Size = new System.Drawing.Size(576, 460);
            this.Food.TabIndex = 0;
            this.Food.Text = "Food";
            this.Food.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(564, 447);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Food);
            this.tabControl1.Controls.Add(this.Drinks);
            this.tabControl1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(45, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 489);
            this.tabControl1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.Product1,
            this.Price1,
            this.Quantity1,
            this.Add1,
            this.Deduct1,
            this.Clear1});
            this.dataGridView1.Location = new System.Drawing.Point(652, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 390);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.Visible = false;
            this.ID1.Width = 25;
            // 
            // Product1
            // 
            this.Product1.HeaderText = "Name";
            this.Product1.Name = "Product1";
            this.Product1.ReadOnly = true;
            this.Product1.Width = 145;
            // 
            // Price1
            // 
            this.Price1.HeaderText = "Price";
            this.Price1.Name = "Price1";
            this.Price1.ReadOnly = true;
            // 
            // Quantity1
            // 
            this.Quantity1.HeaderText = "Quantity";
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.Width = 50;
            // 
            // Add1
            // 
            this.Add1.HeaderText = "";
            this.Add1.Name = "Add1";
            this.Add1.Width = 30;
            // 
            // Deduct1
            // 
            this.Deduct1.HeaderText = "";
            this.Deduct1.Name = "Deduct1";
            this.Deduct1.Width = 30;
            // 
            // Clear1
            // 
            this.Clear1.HeaderText = "";
            this.Clear1.Name = "Clear1";
            this.Clear1.Width = 50;
            // 
            // Pay
            // 
            this.Pay.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pay.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Pay.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Pay.DisabledForeColor = System.Drawing.Color.Gray;
            this.Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Pay.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Pay.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Pay.HoverTextColor = System.Drawing.Color.White;
            this.Pay.Location = new System.Drawing.Point(1018, 505);
            this.Pay.Name = "Pay";
            this.Pay.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Pay.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Pay.NormalTextColor = System.Drawing.Color.White;
            this.Pay.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Pay.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Pay.PressTextColor = System.Drawing.Color.White;
            this.Pay.Size = new System.Drawing.Size(101, 37);
            this.Pay.Style = MetroSet_UI.Design.Style.Light;
            this.Pay.StyleManager = null;
            this.Pay.TabIndex = 13;
            this.Pay.Text = "Pay";
            this.Pay.ThemeAuthor = "Narwin";
            this.Pay.ThemeName = "";
            this.Pay.Click += new System.EventHandler(this.Pay_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotal);
            this.Name = "OrderPage";
            this.Size = new System.Drawing.Size(1249, 599);
            this.Drinks.ResumeLayout(false);
            this.Food.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn Clear;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Drinks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TabPage Food;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity1;
        private System.Windows.Forms.DataGridViewButtonColumn Add1;
        private System.Windows.Forms.DataGridViewButtonColumn Deduct1;
        private System.Windows.Forms.DataGridViewButtonColumn Clear1;
        private MetroSet_UI.Controls.MetroSetButton Pay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
