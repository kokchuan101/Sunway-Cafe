namespace Sunway_Cafe 
{
    partial class SignInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.signInBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.password = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 561);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "We make the BEST\r\n Burgers in Town!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.signInBtn);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(368, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 561);
            this.panel2.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.exitBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.exitBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.exitBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.exitBtn.HoverTextColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(466, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.exitBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.exitBtn.NormalTextColor = System.Drawing.Color.White;
            this.exitBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.exitBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.exitBtn.PressTextColor = System.Drawing.Color.White;
            this.exitBtn.Size = new System.Drawing.Size(47, 42);
            this.exitBtn.Style = MetroSet_UI.Design.Style.Light;
            this.exitBtn.StyleManager = null;
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "X";
            this.exitBtn.ThemeAuthor = "Narwin";
            this.exitBtn.ThemeName = "MetroLite";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.signInBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.signInBtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.signInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.signInBtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.signInBtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.signInBtn.HoverTextColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(39, 315);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.signInBtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.signInBtn.NormalTextColor = System.Drawing.Color.White;
            this.signInBtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.signInBtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.signInBtn.PressTextColor = System.Drawing.Color.White;
            this.signInBtn.Size = new System.Drawing.Size(452, 42);
            this.signInBtn.Style = MetroSet_UI.Design.Style.Light;
            this.signInBtn.StyleManager = null;
            this.signInBtn.TabIndex = 6;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.ThemeAuthor = "Narwin";
            this.signInBtn.ThemeName = "MetroLite";
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // password
            // 
            this.password.AutoCompleteCustomSource = null;
            this.password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.password.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.password.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.password.Image = null;
            this.password.Lines = null;
            this.password.Location = new System.Drawing.Point(39, 214);
            this.password.MaxLength = 32767;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.ReadOnly = false;
            this.password.Size = new System.Drawing.Size(452, 27);
            this.password.Style = MetroSet_UI.Design.Style.Light;
            this.password.StyleManager = null;
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.ThemeAuthor = "Narwin";
            this.password.ThemeName = "MetroLite";
            this.password.UseSystemPasswordChar = false;
            this.password.WatermarkText = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(35, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // username
            // 
            this.username.AutoCompleteCustomSource = null;
            this.username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.username.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.username.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.username.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.username.Image = null;
            this.username.Lines = null;
            this.username.Location = new System.Drawing.Point(39, 143);
            this.username.MaxLength = 32767;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.ReadOnly = false;
            this.username.Size = new System.Drawing.Size(452, 27);
            this.username.Style = MetroSet_UI.Design.Style.Light;
            this.username.StyleManager = null;
            this.username.TabIndex = 2;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.ThemeAuthor = "Narwin";
            this.username.ThemeName = "MetroLite";
            this.username.UseSystemPasswordChar = false;
            this.username.WatermarkText = "";
            this.username.Click += new System.EventHandler(this.metroSetTextBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign In";
            // 
            // SignIn
            // 
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroSet_UI.Controls.MetroSetTextBox username;
        private MetroSet_UI.Controls.MetroSetTextBox password;
        private System.Windows.Forms.Label label4;
        private MetroSet_UI.Controls.MetroSetButton signInBtn;
        private MetroSet_UI.Controls.MetroSetButton exitBtn;
    }
}

