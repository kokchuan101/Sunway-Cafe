namespace Sunway_Cafe
{
    partial class ManagementPage
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.givenName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.familyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addStaff = new MetroSet_UI.Controls.MetroSetButton();
            this.edit = new MetroSet_UI.Controls.MetroSetButton();
            this.delete = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.givenName,
            this.familyName,
            this.role,
            this.gender,
            this.contact,
            this.email});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(590, 280);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 39;
            // 
            // givenName
            // 
            this.givenName.Text = "Given Name";
            this.givenName.Width = 79;
            // 
            // familyName
            // 
            this.familyName.Text = "Family Name";
            this.familyName.Width = 76;
            // 
            // role
            // 
            this.role.Text = "Position";
            this.role.Width = 70;
            // 
            // gender
            // 
            this.gender.Text = "Gender";
            this.gender.Width = 54;
            // 
            // contact
            // 
            this.contact.Text = "Contact";
            this.contact.Width = 91;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 175;
            // 
            // addStaff
            // 
            this.addStaff.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addStaff.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addStaff.DisabledForeColor = System.Drawing.Color.Gray;
            this.addStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addStaff.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addStaff.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addStaff.HoverTextColor = System.Drawing.Color.White;
            this.addStaff.Location = new System.Drawing.Point(52, 337);
            this.addStaff.Name = "addStaff";
            this.addStaff.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addStaff.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addStaff.NormalTextColor = System.Drawing.Color.White;
            this.addStaff.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addStaff.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addStaff.PressTextColor = System.Drawing.Color.White;
            this.addStaff.Size = new System.Drawing.Size(85, 42);
            this.addStaff.Style = MetroSet_UI.Design.Style.Light;
            this.addStaff.StyleManager = null;
            this.addStaff.TabIndex = 19;
            this.addStaff.Text = "Add Staff";
            this.addStaff.ThemeAuthor = "Narwin";
            this.addStaff.ThemeName = "MetroLite";
            this.addStaff.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // edit
            // 
            this.edit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.edit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.edit.DisabledForeColor = System.Drawing.Color.Gray;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.edit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.edit.HoverTextColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(252, 337);
            this.edit.Name = "edit";
            this.edit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.edit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.edit.NormalTextColor = System.Drawing.Color.White;
            this.edit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.edit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.edit.PressTextColor = System.Drawing.Color.White;
            this.edit.Size = new System.Drawing.Size(85, 42);
            this.edit.Style = MetroSet_UI.Design.Style.Light;
            this.edit.StyleManager = null;
            this.edit.TabIndex = 20;
            this.edit.Text = "Edit";
            this.edit.ThemeAuthor = "Narwin";
            this.edit.ThemeName = "MetroLite";
            this.edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // delete
            // 
            this.delete.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.delete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.delete.DisabledForeColor = System.Drawing.Color.Gray;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.delete.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.delete.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.delete.HoverTextColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(456, 337);
            this.delete.Name = "delete";
            this.delete.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.delete.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.delete.NormalTextColor = System.Drawing.Color.White;
            this.delete.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.delete.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.delete.PressTextColor = System.Drawing.Color.White;
            this.delete.Size = new System.Drawing.Size(85, 42);
            this.delete.Style = MetroSet_UI.Design.Style.Light;
            this.delete.StyleManager = null;
            this.delete.TabIndex = 21;
            this.delete.Text = "Delete";
            this.delete.ThemeAuthor = "Narwin";
            this.delete.ThemeName = "MetroLite";
            this.delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // ManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 391);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.addStaff);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManagementPage";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader givenName;
        private System.Windows.Forms.ColumnHeader familyName;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader contact;
        private System.Windows.Forms.ColumnHeader email;
        private MetroSet_UI.Controls.MetroSetButton addStaff;
        private MetroSet_UI.Controls.MetroSetButton edit;
        private MetroSet_UI.Controls.MetroSetButton delete;
    }
}