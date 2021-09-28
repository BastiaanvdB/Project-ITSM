
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
            this.UMBTN = new System.Windows.Forms.Button();
            this.IMBTN = new System.Windows.Forms.Button();
            this.DashboardBTN = new System.Windows.Forms.Button();
            this.lst_UM_Users = new System.Windows.Forms.ListView();
            this.lbl_UM_title = new System.Windows.Forms.Label();
            this.btn_UM_AddUser = new System.Windows.Forms.Button();
            this.btn_UM_EditUser = new System.Windows.Forms.Button();
            this.btn_UM_DeleteUser = new System.Windows.Forms.Button();
            this.btn_UM_Refresh = new System.Windows.Forms.Button();
            this.pnl_UM_AddUser = new System.Windows.Forms.Panel();
            this.txt_UM_AddUser_Job = new System.Windows.Forms.TextBox();
            this.lbl_UM_AddUser_Job = new System.Windows.Forms.Label();
            this.txt_UM_AddUser_LastName = new System.Windows.Forms.TextBox();
            this.lbl_UM_AddUser_LastName = new System.Windows.Forms.Label();
            this.txt_UM_AddUser_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_UM_AddUser_FirstName = new System.Windows.Forms.Label();
            this.txt_UM_AddUser_Id = new System.Windows.Forms.TextBox();
            this.lbl_UM_AddUser_Id = new System.Windows.Forms.Label();
            this.btn_UM_AddUser_Confirm = new System.Windows.Forms.Button();
            this.lbl_UM_AddUser_Title = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.pnl_UM_AddUser.SuspendLayout();
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
            this.lst_UM_Users.FullRowSelect = true;
            this.lst_UM_Users.HideSelection = false;
            this.lst_UM_Users.Location = new System.Drawing.Point(12, 191);
            this.lst_UM_Users.Name = "lst_UM_Users";
            this.lst_UM_Users.Size = new System.Drawing.Size(579, 431);
            this.lst_UM_Users.TabIndex = 1;
            this.lst_UM_Users.UseCompatibleStateImageBehavior = false;
            this.lst_UM_Users.View = System.Windows.Forms.View.Details;
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
            // btn_UM_AddUser
            // 
            this.btn_UM_AddUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_UM_AddUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UM_AddUser.ForeColor = System.Drawing.Color.White;
            this.btn_UM_AddUser.Location = new System.Drawing.Point(704, 191);
            this.btn_UM_AddUser.Name = "btn_UM_AddUser";
            this.btn_UM_AddUser.Size = new System.Drawing.Size(320, 90);
            this.btn_UM_AddUser.TabIndex = 3;
            this.btn_UM_AddUser.Text = "Add User";
            this.btn_UM_AddUser.UseVisualStyleBackColor = false;
            this.btn_UM_AddUser.Click += new System.EventHandler(this.btn_UM_AddUser_Click);
            // 
            // btn_UM_EditUser
            // 
            this.btn_UM_EditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btn_UM_EditUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UM_EditUser.ForeColor = System.Drawing.Color.White;
            this.btn_UM_EditUser.Location = new System.Drawing.Point(831, 319);
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
            this.btn_UM_DeleteUser.Location = new System.Drawing.Point(831, 440);
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
            // pnl_UM_AddUser
            // 
            this.pnl_UM_AddUser.BackColor = System.Drawing.Color.White;
            this.pnl_UM_AddUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_UM_AddUser.Controls.Add(this.txt_UM_AddUser_Job);
            this.pnl_UM_AddUser.Controls.Add(this.lbl_UM_AddUser_Job);
            this.pnl_UM_AddUser.Controls.Add(this.txt_UM_AddUser_LastName);
            this.pnl_UM_AddUser.Controls.Add(this.lbl_UM_AddUser_LastName);
            this.pnl_UM_AddUser.Controls.Add(this.txt_UM_AddUser_FirstName);
            this.pnl_UM_AddUser.Controls.Add(this.lbl_UM_AddUser_FirstName);
            this.pnl_UM_AddUser.Controls.Add(this.txt_UM_AddUser_Id);
            this.pnl_UM_AddUser.Controls.Add(this.lbl_UM_AddUser_Id);
            this.pnl_UM_AddUser.Controls.Add(this.btn_UM_AddUser_Confirm);
            this.pnl_UM_AddUser.Controls.Add(this.lbl_UM_AddUser_Title);
            this.pnl_UM_AddUser.Location = new System.Drawing.Point(183, 139);
            this.pnl_UM_AddUser.Name = "pnl_UM_AddUser";
            this.pnl_UM_AddUser.Size = new System.Drawing.Size(642, 453);
            this.pnl_UM_AddUser.TabIndex = 7;
            // 
            // txt_UM_AddUser_Job
            // 
            this.txt_UM_AddUser_Job.Location = new System.Drawing.Point(127, 214);
            this.txt_UM_AddUser_Job.Name = "txt_UM_AddUser_Job";
            this.txt_UM_AddUser_Job.Size = new System.Drawing.Size(100, 23);
            this.txt_UM_AddUser_Job.TabIndex = 9;
            // 
            // lbl_UM_AddUser_Job
            // 
            this.lbl_UM_AddUser_Job.AutoSize = true;
            this.lbl_UM_AddUser_Job.BackColor = System.Drawing.Color.Gray;
            this.lbl_UM_AddUser_Job.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UM_AddUser_Job.ForeColor = System.Drawing.Color.White;
            this.lbl_UM_AddUser_Job.Location = new System.Drawing.Point(33, 213);
            this.lbl_UM_AddUser_Job.Name = "lbl_UM_AddUser_Job";
            this.lbl_UM_AddUser_Job.Size = new System.Drawing.Size(38, 20);
            this.lbl_UM_AddUser_Job.TabIndex = 8;
            this.lbl_UM_AddUser_Job.Text = "Job:";
            // 
            // txt_UM_AddUser_LastName
            // 
            this.txt_UM_AddUser_LastName.Location = new System.Drawing.Point(127, 180);
            this.txt_UM_AddUser_LastName.Name = "txt_UM_AddUser_LastName";
            this.txt_UM_AddUser_LastName.Size = new System.Drawing.Size(100, 23);
            this.txt_UM_AddUser_LastName.TabIndex = 7;
            // 
            // lbl_UM_AddUser_LastName
            // 
            this.lbl_UM_AddUser_LastName.AutoSize = true;
            this.lbl_UM_AddUser_LastName.BackColor = System.Drawing.Color.Gray;
            this.lbl_UM_AddUser_LastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UM_AddUser_LastName.ForeColor = System.Drawing.Color.White;
            this.lbl_UM_AddUser_LastName.Location = new System.Drawing.Point(33, 179);
            this.lbl_UM_AddUser_LastName.Name = "lbl_UM_AddUser_LastName";
            this.lbl_UM_AddUser_LastName.Size = new System.Drawing.Size(81, 20);
            this.lbl_UM_AddUser_LastName.TabIndex = 6;
            this.lbl_UM_AddUser_LastName.Text = "Lastname:";
            // 
            // txt_UM_AddUser_FirstName
            // 
            this.txt_UM_AddUser_FirstName.Location = new System.Drawing.Point(127, 138);
            this.txt_UM_AddUser_FirstName.Name = "txt_UM_AddUser_FirstName";
            this.txt_UM_AddUser_FirstName.Size = new System.Drawing.Size(100, 23);
            this.txt_UM_AddUser_FirstName.TabIndex = 5;
            // 
            // lbl_UM_AddUser_FirstName
            // 
            this.lbl_UM_AddUser_FirstName.AutoSize = true;
            this.lbl_UM_AddUser_FirstName.BackColor = System.Drawing.Color.Gray;
            this.lbl_UM_AddUser_FirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UM_AddUser_FirstName.ForeColor = System.Drawing.Color.White;
            this.lbl_UM_AddUser_FirstName.Location = new System.Drawing.Point(33, 137);
            this.lbl_UM_AddUser_FirstName.Name = "lbl_UM_AddUser_FirstName";
            this.lbl_UM_AddUser_FirstName.Size = new System.Drawing.Size(83, 20);
            this.lbl_UM_AddUser_FirstName.TabIndex = 4;
            this.lbl_UM_AddUser_FirstName.Text = "Firstname:";
            // 
            // txt_UM_AddUser_Id
            // 
            this.txt_UM_AddUser_Id.Location = new System.Drawing.Point(127, 100);
            this.txt_UM_AddUser_Id.Name = "txt_UM_AddUser_Id";
            this.txt_UM_AddUser_Id.Size = new System.Drawing.Size(100, 23);
            this.txt_UM_AddUser_Id.TabIndex = 3;
            // 
            // lbl_UM_AddUser_Id
            // 
            this.lbl_UM_AddUser_Id.AutoSize = true;
            this.lbl_UM_AddUser_Id.BackColor = System.Drawing.Color.Gray;
            this.lbl_UM_AddUser_Id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UM_AddUser_Id.ForeColor = System.Drawing.Color.White;
            this.lbl_UM_AddUser_Id.Location = new System.Drawing.Point(33, 99);
            this.lbl_UM_AddUser_Id.Name = "lbl_UM_AddUser_Id";
            this.lbl_UM_AddUser_Id.Size = new System.Drawing.Size(65, 20);
            this.lbl_UM_AddUser_Id.TabIndex = 2;
            this.lbl_UM_AddUser_Id.Text = "User ID:";
            // 
            // btn_UM_AddUser_Confirm
            // 
            this.btn_UM_AddUser_Confirm.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_UM_AddUser_Confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UM_AddUser_Confirm.ForeColor = System.Drawing.Color.White;
            this.btn_UM_AddUser_Confirm.Location = new System.Drawing.Point(459, 356);
            this.btn_UM_AddUser_Confirm.Name = "btn_UM_AddUser_Confirm";
            this.btn_UM_AddUser_Confirm.Size = new System.Drawing.Size(153, 74);
            this.btn_UM_AddUser_Confirm.TabIndex = 1;
            this.btn_UM_AddUser_Confirm.Text = "Confirm";
            this.btn_UM_AddUser_Confirm.UseVisualStyleBackColor = false;
            this.btn_UM_AddUser_Confirm.Click += new System.EventHandler(this.btn_UM_AddUser_Confirm_Click);
            // 
            // lbl_UM_AddUser_Title
            // 
            this.lbl_UM_AddUser_Title.AutoSize = true;
            this.lbl_UM_AddUser_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.lbl_UM_AddUser_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UM_AddUser_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_UM_AddUser_Title.Location = new System.Drawing.Point(33, 30);
            this.lbl_UM_AddUser_Title.Name = "lbl_UM_AddUser_Title";
            this.lbl_UM_AddUser_Title.Size = new System.Drawing.Size(119, 32);
            this.lbl_UM_AddUser_Title.TabIndex = 0;
            this.lbl_UM_AddUser_Title.Text = "Add User";
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1036, 634);
            this.Controls.Add(this.pnl_UM_AddUser);
            this.Controls.Add(this.btn_UM_Refresh);
            this.Controls.Add(this.btn_UM_DeleteUser);
            this.Controls.Add(this.btn_UM_EditUser);
            this.Controls.Add(this.btn_UM_AddUser);
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
            this.pnl_UM_AddUser.ResumeLayout(false);
            this.pnl_UM_AddUser.PerformLayout();
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
        private System.Windows.Forms.Button btn_UM_AddUser;
        private System.Windows.Forms.Button btn_UM_EditUser;
        private System.Windows.Forms.Button btn_UM_DeleteUser;
        private System.Windows.Forms.Button btn_UM_Refresh;
        private System.Windows.Forms.Panel pnl_UM_AddUser;
        private System.Windows.Forms.Label lbl_UM_AddUser_Title;
        private System.Windows.Forms.TextBox txt_UM_AddUser_Job;
        private System.Windows.Forms.Label lbl_UM_AddUser_Job;
        private System.Windows.Forms.TextBox txt_UM_AddUser_LastName;
        private System.Windows.Forms.Label lbl_UM_AddUser_LastName;
        private System.Windows.Forms.TextBox txt_UM_AddUser_FirstName;
        private System.Windows.Forms.Label lbl_UM_AddUser_FirstName;
        private System.Windows.Forms.TextBox txt_UM_AddUser_Id;
        private System.Windows.Forms.Label lbl_UM_AddUser_Id;
        private System.Windows.Forms.Button btn_UM_AddUser_Confirm;
    }
}

