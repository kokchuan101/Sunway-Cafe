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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPage));
            this.label1 = new System.Windows.Forms.Label();
            this.Large_img = new System.Windows.Forms.ImageList(this.components);
            this.AddOrder = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pay = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Large_img
            // 
            this.Large_img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Large_img.ImageStream")));
            this.Large_img.TransparentColor = System.Drawing.Color.Transparent;
            this.Large_img.Images.SetKeyName(0, "choices (2).png");
            this.Large_img.Images.SetKeyName(1, "house (1).png");
            this.Large_img.Images.SetKeyName(2, "team (2).png");
            this.Large_img.Images.SetKeyName(3, "choices (2).png");
            this.Large_img.Images.SetKeyName(4, "house (1).png");
            this.Large_img.Images.SetKeyName(5, "team (2).png");
            this.Large_img.Images.SetKeyName(6, "home.png");
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(48, 461);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(109, 23);
            this.AddOrder.TabIndex = 2;
            this.AddOrder.Text = "PlaceOrder";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name_col});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(665, 97);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(175, 290);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Name_col
            // 
            this.Name_col.Text = "Name";
            // 
            // Pay
            // 
            this.Pay.Location = new System.Drawing.Point(665, 448);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(175, 50);
            this.Pay.TabIndex = 4;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(507, 461);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(109, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete Item";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(48, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(568, 336);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.label1);
            this.Name = "OrderPage";
            this.Size = new System.Drawing.Size(873, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList Large_img;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name_col;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
