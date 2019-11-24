namespace Sunway_Cafe
{
    partial class KitchenOrder
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.completeButton = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.orderID = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Qty});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(229, 177);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 160;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            // 
            // completeButton
            // 
            this.completeButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.completeButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.completeButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.completeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.completeButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.completeButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.completeButton.HoverTextColor = System.Drawing.Color.White;
            this.completeButton.Location = new System.Drawing.Point(4, 209);
            this.completeButton.Name = "completeButton";
            this.completeButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.completeButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.completeButton.NormalTextColor = System.Drawing.Color.White;
            this.completeButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.completeButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.completeButton.PressTextColor = System.Drawing.Color.White;
            this.completeButton.Size = new System.Drawing.Size(228, 30);
            this.completeButton.Style = MetroSet_UI.Design.Style.Light;
            this.completeButton.StyleManager = null;
            this.completeButton.TabIndex = 4;
            this.completeButton.Text = "Complete";
            this.completeButton.ThemeAuthor = "Narwin";
            this.completeButton.ThemeName = "MetroLite";
            this.completeButton.Click += new System.EventHandler(this.MetroSetButton1_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(4, 2);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(67, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 5;
            this.metroSetLabel1.Text = "Order ID:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // orderID
            // 
            this.orderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.orderID.Location = new System.Drawing.Point(70, 2);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(55, 23);
            this.orderID.Style = MetroSet_UI.Design.Style.Light;
            this.orderID.StyleManager = null;
            this.orderID.TabIndex = 6;
            this.orderID.Text = "{id}";
            this.orderID.ThemeAuthor = "Narwin";
            this.orderID.ThemeName = "MetroLite";
            // 
            // KitchenOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.listView1);
            this.Name = "KitchenOrder";
            this.Size = new System.Drawing.Size(237, 244);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Qty;
        private MetroSet_UI.Controls.MetroSetButton completeButton;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel orderID;
    }
}
