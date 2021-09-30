
namespace NoDeskUI
{
    partial class UserManagment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagment));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LabelLicense = new System.Windows.Forms.Label();
            this.LabelCurrentUser = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonKeyManagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UMBTN = new System.Windows.Forms.Button();
            this.IMBTN = new System.Windows.Forms.Button();
            this.DashboardBTN = new System.Windows.Forms.Button();
            this.lst_UM_Users = new System.Windows.Forms.ListView();
            this.col_ID = new System.Windows.Forms.ColumnHeader();
            this.col_FirstName = new System.Windows.Forms.ColumnHeader();
            this.col_LastName = new System.Windows.Forms.ColumnHeader();
            this.col_Email = new System.Windows.Forms.ColumnHeader();
            this.col_Company = new System.Windows.Forms.ColumnHeader();
            this.lbl_UM_title = new System.Windows.Forms.Label();
            this.btn_UM_EditUser = new System.Windows.Forms.Button();
            this.btn_UM_DeleteUser = new System.Windows.Forms.Button();
            this.btn_UM_Refresh = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.TopPanel.Controls.Add(this.LabelLicense);
            this.TopPanel.Controls.Add(this.LabelCurrentUser);
            this.TopPanel.Controls.Add(this.lbl_logo);
            this.TopPanel.Controls.Add(this.MenuPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1036, 133);
            this.TopPanel.TabIndex = 0;
            // 
            // LabelLicense
            // 
            this.LabelLicense.AutoSize = true;
            this.LabelLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLicense.ForeColor = System.Drawing.Color.White;
            this.LabelLicense.Location = new System.Drawing.Point(840, 76);
            this.LabelLicense.Name = "LabelLicense";
            this.LabelLicense.Size = new System.Drawing.Size(67, 13);
            this.LabelLicense.TabIndex = 3;
            this.LabelLicense.Text = "Licensed to:";
            // 
            // LabelCurrentUser
            // 
            this.LabelCurrentUser.AutoSize = true;
            this.LabelCurrentUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelCurrentUser.ForeColor = System.Drawing.Color.White;
            this.LabelCurrentUser.Location = new System.Drawing.Point(840, 61);
            this.LabelCurrentUser.Name = "LabelCurrentUser";
            this.LabelCurrentUser.Size = new System.Drawing.Size(75, 15);
            this.LabelCurrentUser.TabIndex = 2;
            this.LabelCurrentUser.Text = "Current User:";
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Segoe UI", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_logo.Location = new System.Drawing.Point(831, 0);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(193, 61);
            this.lbl_logo.TabIndex = 1;
            this.lbl_logo.Text = "NoDesk";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.MenuPanel.Controls.Add(this.buttonLogout);
            this.MenuPanel.Controls.Add(this.buttonKeyManagement);
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Controls.Add(this.UMBTN);
            this.MenuPanel.Controls.Add(this.IMBTN);
            this.MenuPanel.Controls.Add(this.DashboardBTN);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.MenuPanel.Location = new System.Drawing.Point(0, 92);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1036, 41);
            this.MenuPanel.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(956, 9);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(77, 25);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonKeyManagement
            // 
            this.buttonKeyManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.buttonKeyManagement.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonKeyManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeyManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKeyManagement.ForeColor = System.Drawing.Color.White;
            this.buttonKeyManagement.Image = global::NoDeskUI.Properties.Resources.key_6_24;
            this.buttonKeyManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKeyManagement.Location = new System.Drawing.Point(679, 0);
            this.buttonKeyManagement.Name = "buttonKeyManagement";
            this.buttonKeyManagement.Size = new System.Drawing.Size(183, 41);
            this.buttonKeyManagement.TabIndex = 17;
            this.buttonKeyManagement.Text = "Key Management";
            this.buttonKeyManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKeyManagement.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::NoDeskUI.Properties.Resources.administrator_2_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(532, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Admin Panel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UMBTN
            // 
            this.UMBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.UMBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.UMBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UMBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UMBTN.ForeColor = System.Drawing.Color.White;
            this.UMBTN.Image = global::NoDeskUI.Properties.Resources.user_5_24;
            this.UMBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UMBTN.Location = new System.Drawing.Point(345, 0);
            this.UMBTN.Name = "UMBTN";
            this.UMBTN.Size = new System.Drawing.Size(187, 41);
            this.UMBTN.TabIndex = 2;
            this.UMBTN.Text = "User Management";
            this.UMBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UMBTN.UseVisualStyleBackColor = false;
            // 
            // IMBTN
            // 
            this.IMBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.IMBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.IMBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IMBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IMBTN.ForeColor = System.Drawing.Color.White;
            this.IMBTN.Image = global::NoDeskUI.Properties.Resources.paper_24;
            this.IMBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IMBTN.Location = new System.Drawing.Point(131, 0);
            this.IMBTN.Name = "IMBTN";
            this.IMBTN.Size = new System.Drawing.Size(214, 41);
            this.IMBTN.TabIndex = 1;
            this.IMBTN.Text = "Incident Management";
            this.IMBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IMBTN.UseVisualStyleBackColor = false;
            this.IMBTN.Click += new System.EventHandler(this.IMBTN_Click_1);
            // 
            // DashboardBTN
            // 
            this.DashboardBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.DashboardBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.DashboardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardBTN.ForeColor = System.Drawing.Color.White;
            this.DashboardBTN.Image = global::NoDeskUI.Properties.Resources.dashboard_2_24;
            this.DashboardBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBTN.Location = new System.Drawing.Point(0, 0);
            this.DashboardBTN.Name = "DashboardBTN";
            this.DashboardBTN.Size = new System.Drawing.Size(131, 41);
            this.DashboardBTN.TabIndex = 0;
            this.DashboardBTN.Text = "Dashboard";
            this.DashboardBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardBTN.UseVisualStyleBackColor = false;
            this.DashboardBTN.Click += new System.EventHandler(this.DashboardBTN_Click);
            // 
            // lst_UM_Users
            // 
            this.lst_UM_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_FirstName,
            this.col_LastName,
            this.col_Email,
            this.col_Company});
            this.lst_UM_Users.FullRowSelect = true;
            this.lst_UM_Users.HideSelection = false;
            this.lst_UM_Users.Location = new System.Drawing.Point(12, 191);
            this.lst_UM_Users.Name = "lst_UM_Users";
            this.lst_UM_Users.Size = new System.Drawing.Size(579, 431);
            this.lst_UM_Users.TabIndex = 1;
            this.lst_UM_Users.UseCompatibleStateImageBehavior = false;
            this.lst_UM_Users.View = System.Windows.Forms.View.Details;
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            this.col_ID.Width = 160;
            // 
            // col_FirstName
            // 
            this.col_FirstName.Text = "Firstname";
            this.col_FirstName.Width = 80;
            // 
            // col_LastName
            // 
            this.col_LastName.Text = "Lastname";
            this.col_LastName.Width = 80;
            // 
            // col_Email
            // 
            this.col_Email.Text = "E-Mail Address";
            this.col_Email.Width = 170;
            // 
            // col_Company
            // 
            this.col_Company.Text = "Company";
            this.col_Company.Width = 80;
            // 
            // lbl_UM_title
            // 
            this.lbl_UM_title.AutoSize = true;
            this.lbl_UM_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.lbl_UM_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UM_title.ForeColor = System.Drawing.Color.White;
            this.lbl_UM_title.Location = new System.Drawing.Point(12, 154);
            this.lbl_UM_title.Name = "lbl_UM_title";
            this.lbl_UM_title.Size = new System.Drawing.Size(163, 32);
            this.lbl_UM_title.TabIndex = 2;
            this.lbl_UM_title.Text = "System Users";
            // 
            // btn_UM_EditUser
            // 
            this.btn_UM_EditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btn_UM_EditUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UM_EditUser.ForeColor = System.Drawing.Color.White;
            this.btn_UM_EditUser.Location = new System.Drawing.Point(831, 174);
            this.btn_UM_EditUser.Name = "btn_UM_EditUser";
            this.btn_UM_EditUser.Size = new System.Drawing.Size(193, 85);
            this.btn_UM_EditUser.TabIndex = 4;
            this.btn_UM_EditUser.Text = "Edit User ";
            this.btn_UM_EditUser.UseVisualStyleBackColor = false;
            this.btn_UM_EditUser.Click += new System.EventHandler(this.btn_UM_EditUser_Click);
            // 
            // btn_UM_DeleteUser
            // 
            this.btn_UM_DeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_UM_DeleteUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UM_DeleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_UM_DeleteUser.Location = new System.Drawing.Point(831, 296);
            this.btn_UM_DeleteUser.Name = "btn_UM_DeleteUser";
            this.btn_UM_DeleteUser.Size = new System.Drawing.Size(193, 50);
            this.btn_UM_DeleteUser.TabIndex = 5;
            this.btn_UM_DeleteUser.Text = "Delete User";
            this.btn_UM_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_UM_DeleteUser.Click += new System.EventHandler(this.btn_UM_DeleteUser_Click);
            // 
            // btn_UM_Refresh
            // 
            this.btn_UM_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_UM_Refresh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UM_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_UM_Refresh.Location = new System.Drawing.Point(410, 154);
            this.btn_UM_Refresh.Name = "btn_UM_Refresh";
            this.btn_UM_Refresh.Size = new System.Drawing.Size(181, 32);
            this.btn_UM_Refresh.TabIndex = 6;
            this.btn_UM_Refresh.Text = "Refresh";
            this.btn_UM_Refresh.UseVisualStyleBackColor = false;
            this.btn_UM_Refresh.Click += new System.EventHandler(this.btn_UM_Refresh_Click);
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1036, 634);
            this.Controls.Add(this.btn_UM_Refresh);
            this.Controls.Add(this.btn_UM_DeleteUser);
            this.Controls.Add(this.btn_UM_EditUser);
            this.Controls.Add(this.lbl_UM_title);
            this.Controls.Add(this.lst_UM_Users);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoDesk | User Management";
            this.Load += new System.EventHandler(this.NoDesk_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button IMBTN;
        private System.Windows.Forms.Button DashboardBTN;
        private System.Windows.Forms.Button UMBTN;
        private System.Windows.Forms.Label LabelCurrentUser;
        private System.Windows.Forms.Label LabelLicense;
        private System.Windows.Forms.ListView lst_UM_Users;
        private System.Windows.Forms.Label lbl_UM_title;
        private System.Windows.Forms.Button btn_UM_EditUser;
        private System.Windows.Forms.Button btn_UM_DeleteUser;
        private System.Windows.Forms.Button btn_UM_Refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonKeyManagement;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_FirstName;
        private System.Windows.Forms.ColumnHeader col_LastName;
        private System.Windows.Forms.ColumnHeader col_Email;
        private System.Windows.Forms.ColumnHeader col_Company;
    }
}

