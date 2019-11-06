namespace Sunway_Cafe
{
    partial class PromptDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.tryAgainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wrong";
            // 
            // tryAgainBtn
            // 
            this.tryAgainBtn.Location = new System.Drawing.Point(113, 197);
            this.tryAgainBtn.Name = "tryAgainBtn";
            this.tryAgainBtn.Size = new System.Drawing.Size(75, 23);
            this.tryAgainBtn.TabIndex = 1;
            this.tryAgainBtn.Text = "Try Again";
            this.tryAgainBtn.UseVisualStyleBackColor = true;
            this.tryAgainBtn.Click += new System.EventHandler(this.tryAgainBtn_Click);
            // 
            // PromptDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 335);
            this.Controls.Add(this.tryAgainBtn);
            this.Controls.Add(this.label1);
            this.Name = "PromptDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PromptDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tryAgainBtn;
    }
}