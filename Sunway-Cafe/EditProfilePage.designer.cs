namespace Sunway_Cafe
{
    partial class EditProfilePage
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.role = new MetroSet_UI.Controls.MetroSetComboBox();
            this.gender = new MetroSet_UI.Controls.MetroSetComboBox();
            this.username = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.password = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.exitBtn = new MetroSet_UI.Controls.MetroSetButton();
            this.editProfile = new MetroSet_UI.Controls.MetroSetButton();
            this.email = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contact = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.givenName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.familyName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label3 = new System.Windows.Forms.Label();

            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.role);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.editProfile);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.contact);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.givenName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.familyName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 551);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
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
            this.exitBtn.Location = new System.Drawing.Point(287, 12);
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
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "X";
            this.exitBtn.ThemeAuthor = "Narwin";
            this.exitBtn.ThemeName = "MetroLite";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // role
            // 
            this.role.AllowDrop = true;
            this.role.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.role.BackColor = System.Drawing.Color.Transparent;
            this.role.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.role.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.role.CausesValidation = false;
            this.role.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.role.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.role.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.role.FormattingEnabled = true;
            this.role.ItemHeight = 20;
            this.role.Items.AddRange(new object[] {
            "Admin",
            "SalesStaff"});
            this.role.Location = new System.Drawing.Point(26, 176);
            this.role.Name = "role";
            this.role.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.role.SelectedItemForeColor = System.Drawing.Color.White;
            this.role.Size = new System.Drawing.Size(145, 26);
            this.role.Style = MetroSet_UI.Design.Style.Light;
            this.role.StyleManager = null;
            this.role.TabIndex = 31;
            this.role.ThemeAuthor = "Narwin";
            this.role.ThemeName = "MetroLite";
            // 
            // gender
            // 
            this.gender.AllowDrop = true;
            this.gender.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.gender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.gender.CausesValidation = false;
            this.gender.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gender.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.gender.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.gender.FormattingEnabled = true;
            this.gender.ItemHeight = 20;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gender.Location = new System.Drawing.Point(26, 337);
            this.gender.Name = "gender";
            this.gender.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.gender.SelectedItemForeColor = System.Drawing.Color.White;
            this.gender.Size = new System.Drawing.Size(121, 26);
            this.gender.Style = MetroSet_UI.Design.Style.Light;
            this.gender.StyleManager = null;
            this.gender.TabIndex = 30;
            this.gender.ThemeAuthor = "Narwin";
            this.gender.ThemeName = "MetroLite";
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
            this.username.Location = new System.Drawing.Point(26, 67);
            this.username.MaxLength = 32767;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.ReadOnly = false;
            this.username.Size = new System.Drawing.Size(308, 27);
            this.username.Style = MetroSet_UI.Design.Style.Light;
            this.username.StyleManager = null;
            this.username.TabIndex = 29;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.ThemeAuthor = "Narwin";
            this.username.ThemeName = "MetroLite";
            this.username.UseSystemPasswordChar = false;
            this.username.WatermarkText = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(22, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Username";
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
            this.password.Location = new System.Drawing.Point(26, 121);
            this.password.MaxLength = 32767;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.ReadOnly = false;
            this.password.Size = new System.Drawing.Size(308, 27);
            this.password.Style = MetroSet_UI.Design.Style.Light;
            this.password.StyleManager = null;
            this.password.TabIndex = 27;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.ThemeAuthor = "Narwin";
            this.password.ThemeName = "MetroLite";
            this.password.UseSystemPasswordChar = true;
            this.password.WatermarkText = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(22, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(22, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Position";
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
            this.exitBtn.Location = new System.Drawing.Point(287, 12);
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
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "X";
            this.exitBtn.ThemeAuthor = "Narwin";
            this.exitBtn.ThemeName = "MetroLite";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // editProfile
            // 
            this.editProfile.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editProfile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editProfile.DisabledForeColor = System.Drawing.Color.Gray;
            this.editProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editProfile.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.editProfile.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.editProfile.HoverTextColor = System.Drawing.Color.White;
            this.editProfile.Location = new System.Drawing.Point(26, 487);
            this.editProfile.Name = "editProfile";
            this.editProfile.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editProfile.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editProfile.NormalTextColor = System.Drawing.Color.White;
            this.editProfile.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.editProfile.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.editProfile.PressTextColor = System.Drawing.Color.White;
            this.editProfile.Size = new System.Drawing.Size(308, 42);
            this.editProfile.Style = MetroSet_UI.Design.Style.Light;
            this.editProfile.StyleManager = null;
            this.editProfile.TabIndex = 18;
            this.editProfile.Text = "Edit Profile";
            this.editProfile.ThemeAuthor = "Narwin";
            this.editProfile.ThemeName = "MetroLite";
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
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
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.email.Image = null;
            this.email.Lines = null;
            this.email.Location = new System.Drawing.Point(26, 445);
            this.email.MaxLength = 32767;
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.ReadOnly = false;
            this.email.Size = new System.Drawing.Size(308, 27);
            this.email.Style = MetroSet_UI.Design.Style.Light;
            this.email.StyleManager = null;
            this.email.TabIndex = 16;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.ThemeAuthor = "Narwin";
            this.email.ThemeName = "MetroLite";
            this.email.UseSystemPasswordChar = false;
            this.email.WatermarkText = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(22, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
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
            this.contact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.contact.Image = null;
            this.contact.Lines = null;
            this.contact.Location = new System.Drawing.Point(26, 391);
            this.contact.MaxLength = 32767;
            this.contact.Multiline = false;
            this.contact.Name = "contact";
            this.contact.ReadOnly = false;
            this.contact.Size = new System.Drawing.Size(308, 27);
            this.contact.Style = MetroSet_UI.Design.Style.Light;
            this.contact.StyleManager = null;
            this.contact.TabIndex = 14;
            this.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contact.ThemeAuthor = "Narwin";
            this.contact.ThemeName = "MetroLite";
            this.contact.UseSystemPasswordChar = false;
            this.contact.WatermarkText = "";
            this.contact.Validating += new System.ComponentModel.CancelEventHandler(this.contact_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(22, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(22, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gender";
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
            this.givenName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givenName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.givenName.Image = null;
            this.givenName.Lines = null;
            this.givenName.Location = new System.Drawing.Point(26, 283);
            this.givenName.MaxLength = 32767;
            this.givenName.Multiline = false;
            this.givenName.Name = "givenName";
            this.givenName.ReadOnly = false;
            this.givenName.Size = new System.Drawing.Size(308, 27);
            this.givenName.Style = MetroSet_UI.Design.Style.Light;
            this.givenName.StyleManager = null;
            this.givenName.TabIndex = 10;
            this.givenName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.givenName.ThemeAuthor = "Narwin";
            this.givenName.ThemeName = "MetroLite";
            this.givenName.UseSystemPasswordChar = false;
            this.givenName.WatermarkText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(22, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Given Name";
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
            this.familyName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familyName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.familyName.Image = null;
            this.familyName.Lines = null;
            this.familyName.Location = new System.Drawing.Point(26, 229);
            this.familyName.MaxLength = 32767;
            this.familyName.Multiline = false;
            this.familyName.Name = "familyName";
            this.familyName.ReadOnly = false;
            this.familyName.Size = new System.Drawing.Size(308, 27);
            this.familyName.Style = MetroSet_UI.Design.Style.Light;
            this.familyName.StyleManager = null;
            this.familyName.TabIndex = 8;
            this.familyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.familyName.ThemeAuthor = "Narwin";
            this.familyName.ThemeName = "MetroLite";
            this.familyName.UseSystemPasswordChar = false;
            this.familyName.WatermarkText = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(22, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Family Name ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 

            // EditProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetTextBox email;
        private System.Windows.Forms.Label label5;
        private MetroSet_UI.Controls.MetroSetTextBox contact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MetroSet_UI.Controls.MetroSetTextBox givenName;
        private System.Windows.Forms.Label label1;
        private MetroSet_UI.Controls.MetroSetTextBox familyName;
        private System.Windows.Forms.Label label3;
        private MetroSet_UI.Controls.MetroSetButton editProfile;
        private MetroSet_UI.Controls.MetroSetButton exitBtn;
        public System.Windows.Forms.Label label6;
        private MetroSet_UI.Controls.MetroSetTextBox username;
        private System.Windows.Forms.Label label7;
        private MetroSet_UI.Controls.MetroSetTextBox password;
        private System.Windows.Forms.Label label8;
        private MetroSet_UI.Controls.MetroSetComboBox gender;
        public MetroSet_UI.Controls.MetroSetComboBox role;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}