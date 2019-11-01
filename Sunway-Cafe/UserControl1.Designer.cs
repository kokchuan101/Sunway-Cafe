namespace Sunway_Cafe
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.Order = new System.Windows.Forms.Button();
            this.Manage = new System.Windows.Forms.Button();
            this.labelHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Order
            // 
            this.Order.Image = ((System.Drawing.Image)(resources.GetObject("Order.Image")));
            this.Order.Location = new System.Drawing.Point(55, 116);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(134, 122);
            this.Order.TabIndex = 0;
            this.Order.Text = "Order";
            this.Order.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manage
            // 
            this.Manage.Image = ((System.Drawing.Image)(resources.GetObject("Manage.Image")));
            this.Manage.Location = new System.Drawing.Point(241, 116);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(134, 122);
            this.Manage.TabIndex = 2;
            this.Manage.Text = "Manage";
            this.Manage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Manage.UseVisualStyleBackColor = true;
            this.Manage.Click += new System.EventHandler(this.Manage_Click);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.Location = new System.Drawing.Point(383, 42);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(102, 37);
            this.labelHome.TabIndex = 3;
            this.labelHome.Text = "Home";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.Manage);
            this.Controls.Add(this.Order);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(920, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button Manage;
        private System.Windows.Forms.Label labelHome;
    }
}
