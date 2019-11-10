namespace Sunway_Cafe
{
    partial class OrderOptions
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
            this.nameDet = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameDet
            // 
            this.nameDet.AutoSize = true;
            this.nameDet.Location = new System.Drawing.Point(67, 172);
            this.nameDet.Name = "nameDet";
            this.nameDet.Size = new System.Drawing.Size(35, 13);
            this.nameDet.TabIndex = 1;
            this.nameDet.Text = "label1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(20, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(143, 146);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // OrderOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.nameDet);
            this.Name = "OrderOptions";
            this.Size = new System.Drawing.Size(184, 204);
            this.Load += new System.EventHandler(this.OrderOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameDet;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
