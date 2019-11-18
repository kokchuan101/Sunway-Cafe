namespace Sunway_Cafe
{
    partial class ProfilePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.editProfile = new MetroSet_UI.Controls.MetroSetButton();
            this.label1 = new System.Windows.Forms.Label();
            this.familyName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.contact = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gender = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.position = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.givenName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.givenName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.contact);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.familyName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.editProfile);
            this.panel1.Location = new System.Drawing.Point(31, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 459);
            this.panel1.TabIndex = 6;
            // 
            // editProfile
            // 
            this.editProfile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editProfile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editProfile.DisabledForeColor = System.Drawing.Color.Gray;
            this.editProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfile.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.editProfile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.editProfile.HoverTextColor = System.Drawing.Color.White;
            this.editProfile.Location = new System.Drawing.Point(755, 362);
            this.editProfile.Name = "editProfile";
            this.editProfile.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editProfile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editProfile.NormalTextColor = System.Drawing.Color.White;
            this.editProfile.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.editProfile.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.editProfile.PressTextColor = System.Drawing.Color.White;
            this.editProfile.Size = new System.Drawing.Size(251, 72);
            this.editProfile.Style = MetroSet_UI.Design.Style.Light;
            this.editProfile.StyleManager = null;
            this.editProfile.TabIndex = 31;
            this.editProfile.Text = "Edit Profile";
            this.editProfile.ThemeAuthor = "Narwin";
            this.editProfile.ThemeName = "MetroLite";
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Family Name";
            // 
            // familyName
            // 
            this.familyName.AutoCompleteCustomSource = null;
            this.familyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.familyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.familyName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.familyName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.familyName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.familyName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.familyName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familyName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.familyName.Image = null;
            this.familyName.Lines = null;
            this.familyName.Location = new System.Drawing.Point(45, 135);
            this.familyName.MaxLength = 32767;
            this.familyName.Multiline = false;
            this.familyName.Name = "familyName";
            this.familyName.ReadOnly = true;
            this.familyName.Size = new System.Drawing.Size(961, 37);
            this.familyName.Style = MetroSet_UI.Design.Style.Light;
            this.familyName.StyleManager = null;
            this.familyName.TabIndex = 35;
            this.familyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.familyName.ThemeAuthor = "Narwin";
            this.familyName.ThemeName = "MetroLite";
            this.familyName.UseSystemPasswordChar = false;
            this.familyName.WatermarkText = "";
            // 
            // contact
            // 
            this.contact.AutoCompleteCustomSource = null;
            this.contact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.contact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.contact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.contact.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.contact.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.contact.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.contact.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.contact.Image = null;
            this.contact.Lines = null;
            this.contact.Location = new System.Drawing.Point(544, 211);
            this.contact.MaxLength = 32767;
            this.contact.Multiline = false;
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Size = new System.Drawing.Size(462, 37);
            this.contact.Style = MetroSet_UI.Design.Style.Light;
            this.contact.StyleManager = null;
            this.contact.TabIndex = 41;
            this.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contact.ThemeAuthor = "Narwin";
            this.contact.ThemeName = "MetroLite";
            this.contact.UseSystemPasswordChar = false;
            this.contact.WatermarkText = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(538, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 33);
            this.label3.TabIndex = 40;
            this.label3.Text = "Contact";
            // 
            // gender
            // 
            this.gender.AutoCompleteCustomSource = null;
            this.gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.gender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.gender.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gender.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.gender.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.gender.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.gender.Image = null;
            this.gender.Lines = null;
            this.gender.Location = new System.Drawing.Point(45, 211);
            this.gender.MaxLength = 32767;
            this.gender.Multiline = false;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Size = new System.Drawing.Size(446, 37);
            this.gender.Style = MetroSet_UI.Design.Style.Light;
            this.gender.StyleManager = null;
            this.gender.TabIndex = 39;
            this.gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gender.ThemeAuthor = "Narwin";
            this.gender.ThemeName = "MetroLite";
            this.gender.UseSystemPasswordChar = false;
            this.gender.WatermarkText = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 33);
            this.label5.TabIndex = 38;
            this.label5.Text = "Gender";
            // 
            // position
            // 
            this.position.AutoCompleteCustomSource = null;
            this.position.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.position.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.position.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.position.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.position.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.position.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.position.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.position.Image = null;
            this.position.Lines = null;
            this.position.Location = new System.Drawing.Point(45, 287);
            this.position.MaxLength = 32767;
            this.position.Multiline = false;
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Size = new System.Drawing.Size(446, 37);
            this.position.Style = MetroSet_UI.Design.Style.Light;
            this.position.StyleManager = null;
            this.position.TabIndex = 43;
            this.position.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.position.ThemeAuthor = "Narwin";
            this.position.ThemeName = "MetroLite";
            this.position.UseSystemPasswordChar = false;
            this.position.WatermarkText = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 33);
            this.label4.TabIndex = 42;
            this.label4.Text = "Position";
            // 
            // email
            // 
            this.email.AutoCompleteCustomSource = null;
            this.email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.email.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.email.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.email.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.email.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.email.Image = null;
            this.email.Lines = null;
            this.email.Location = new System.Drawing.Point(544, 287);
            this.email.MaxLength = 32767;
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(462, 37);
            this.email.Style = MetroSet_UI.Design.Style.Light;
            this.email.StyleManager = null;
            this.email.TabIndex = 45;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.ThemeAuthor = "Narwin";
            this.email.ThemeName = "MetroLite";
            this.email.UseSystemPasswordChar = false;
            this.email.WatermarkText = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(538, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 33);
            this.label6.TabIndex = 44;
            this.label6.Text = "Email";
            // 
            // givenName
            // 
            this.givenName.AutoCompleteCustomSource = null;
            this.givenName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.givenName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.givenName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.givenName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.givenName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.givenName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.givenName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givenName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.givenName.Image = null;
            this.givenName.Lines = null;
            this.givenName.Location = new System.Drawing.Point(45, 59);
            this.givenName.MaxLength = 32767;
            this.givenName.Multiline = false;
            this.givenName.Name = "givenName";
            this.givenName.ReadOnly = true;
            this.givenName.Size = new System.Drawing.Size(961, 37);
            this.givenName.Style = MetroSet_UI.Design.Style.Light;
            this.givenName.StyleManager = null;
            this.givenName.TabIndex = 47;
            this.givenName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.givenName.ThemeAuthor = "Narwin";
            this.givenName.ThemeName = "MetroLite";
            this.givenName.UseSystemPasswordChar = false;
            this.givenName.WatermarkText = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 33);
            this.label2.TabIndex = 46;
            this.label2.Text = "Given Name";
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 505);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetButton editProfile;
        private MetroSet_UI.Controls.MetroSetTextBox familyName;
        private System.Windows.Forms.Label label1;
        private MetroSet_UI.Controls.MetroSetTextBox email;
        private System.Windows.Forms.Label label6;
        private MetroSet_UI.Controls.MetroSetTextBox position;
        private System.Windows.Forms.Label label4;
        private MetroSet_UI.Controls.MetroSetTextBox contact;
        private System.Windows.Forms.Label label3;
        private MetroSet_UI.Controls.MetroSetTextBox gender;
        private System.Windows.Forms.Label label5;
        private MetroSet_UI.Controls.MetroSetTextBox givenName;
        private System.Windows.Forms.Label label2;
    }
}