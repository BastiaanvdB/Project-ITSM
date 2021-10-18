
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagment));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LabelLicense = new System.Windows.Forms.Label();
            this.LabelCurrentUser = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.KMBTN = new System.Windows.Forms.Button();
            this.UMBTN = new System.Windows.Forms.Button();
            this.IMBTN = new System.Windows.Forms.Button();
            this.DashboardBTN = new System.Windows.Forms.Button();
            this.col_ID = new System.Windows.Forms.ColumnHeader();
            this.col_FirstName = new System.Windows.Forms.ColumnHeader();
            this.col_LastName = new System.Windows.Forms.ColumnHeader();
            this.col_Email = new System.Windows.Forms.ColumnHeader();
            this.col_Company = new System.Windows.Forms.ColumnHeader();
            this.lbl_UM_title = new System.Windows.Forms.Label();
            this.btn_UM_EditUser = new System.Windows.Forms.Button();
            this.btn_UM_DeleteUser = new System.Windows.Forms.Button();
            this.btn_UM_Refresh = new System.Windows.Forms.Button();
            this.pnl_UpdateUser = new System.Windows.Forms.Panel();
            this.btn_CancelUpdateUser = new System.Windows.Forms.Button();
            this.btn_UpdateUserConfirm = new System.Windows.Forms.Button();
            this.txt_NewEmailInput = new System.Windows.Forms.TextBox();
            this.lbl_UpdateUserEmail = new System.Windows.Forms.Label();
            this.lbl_UpdateUserTitle = new System.Windows.Forms.Label();
            this.dgv_UserData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textBoxKeyOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.pnl_UpdateUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserData)).BeginInit();
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
            this.MenuPanel.Controls.Add(this.KMBTN);
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
            // KMBTN
            // 
            this.KMBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.KMBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.KMBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KMBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KMBTN.ForeColor = System.Drawing.Color.White;
            this.KMBTN.Image = global::NoDeskUI.Properties.Resources.key_6_24;
            this.KMBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KMBTN.Location = new System.Drawing.Point(532, 0);
            this.KMBTN.Name = "KMBTN";
            this.KMBTN.Size = new System.Drawing.Size(183, 41);
            this.KMBTN.TabIndex = 17;
            this.KMBTN.Text = "Key Management";
            this.KMBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KMBTN.UseVisualStyleBackColor = false;
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
            this.btn_UM_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
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
            // pnl_UpdateUser
            // 
            this.pnl_UpdateUser.BackColor = System.Drawing.Color.Silver;
            this.pnl_UpdateUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_UpdateUser.Controls.Add(this.btn_CancelUpdateUser);
            this.pnl_UpdateUser.Controls.Add(this.btn_UpdateUserConfirm);
            this.pnl_UpdateUser.Controls.Add(this.txt_NewEmailInput);
            this.pnl_UpdateUser.Controls.Add(this.lbl_UpdateUserEmail);
            this.pnl_UpdateUser.Controls.Add(this.lbl_UpdateUserTitle);
            this.pnl_UpdateUser.Location = new System.Drawing.Point(450, 250);
            this.pnl_UpdateUser.Name = "pnl_UpdateUser";
            this.pnl_UpdateUser.Size = new System.Drawing.Size(338, 148);
            this.pnl_UpdateUser.TabIndex = 7;
            // 
            // btn_CancelUpdateUser
            // 
            this.btn_CancelUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_CancelUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btn_CancelUpdateUser.Location = new System.Drawing.Point(13, 114);
            this.btn_CancelUpdateUser.Name = "btn_CancelUpdateUser";
            this.btn_CancelUpdateUser.Size = new System.Drawing.Size(78, 29);
            this.btn_CancelUpdateUser.TabIndex = 4;
            this.btn_CancelUpdateUser.Text = "Cancel";
            this.btn_CancelUpdateUser.UseVisualStyleBackColor = false;
            this.btn_CancelUpdateUser.Click += new System.EventHandler(this.btn_CancelUpdateUser_Click);
            // 
            // btn_UpdateUserConfirm
            // 
            this.btn_UpdateUserConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btn_UpdateUserConfirm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_UpdateUserConfirm.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateUserConfirm.Location = new System.Drawing.Point(230, 103);
            this.btn_UpdateUserConfirm.Name = "btn_UpdateUserConfirm";
            this.btn_UpdateUserConfirm.Size = new System.Drawing.Size(103, 40);
            this.btn_UpdateUserConfirm.TabIndex = 3;
            this.btn_UpdateUserConfirm.Text = "Confirm";
            this.btn_UpdateUserConfirm.UseVisualStyleBackColor = false;
            this.btn_UpdateUserConfirm.Click += new System.EventHandler(this.btn_UpdateUserConfirm_Click);
            // 
            // txt_NewEmailInput
            // 
            this.txt_NewEmailInput.ForeColor = System.Drawing.Color.Black;
            this.txt_NewEmailInput.Location = new System.Drawing.Point(109, 70);
            this.txt_NewEmailInput.Name = "txt_NewEmailInput";
            this.txt_NewEmailInput.Size = new System.Drawing.Size(138, 23);
            this.txt_NewEmailInput.TabIndex = 2;
            // 
            // lbl_UpdateUserEmail
            // 
            this.lbl_UpdateUserEmail.AutoSize = true;
            this.lbl_UpdateUserEmail.BackColor = System.Drawing.Color.White;
            this.lbl_UpdateUserEmail.Location = new System.Drawing.Point(13, 73);
            this.lbl_UpdateUserEmail.Name = "lbl_UpdateUserEmail";
            this.lbl_UpdateUserEmail.Size = new System.Drawing.Size(69, 15);
            this.lbl_UpdateUserEmail.TabIndex = 1;
            this.lbl_UpdateUserEmail.Text = "New Email: ";
            // 
            // lbl_UpdateUserTitle
            // 
            this.lbl_UpdateUserTitle.AutoSize = true;
            this.lbl_UpdateUserTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.lbl_UpdateUserTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_UpdateUserTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_UpdateUserTitle.Location = new System.Drawing.Point(13, 20);
            this.lbl_UpdateUserTitle.Name = "lbl_UpdateUserTitle";
            this.lbl_UpdateUserTitle.Size = new System.Drawing.Size(122, 25);
            this.lbl_UpdateUserTitle.TabIndex = 0;
            this.lbl_UpdateUserTitle.Text = "Update User";
            // 
            // dgv_UserData
            // 
            this.dgv_UserData.AllowUserToAddRows = false;
            this.dgv_UserData.AllowUserToDeleteRows = false;
            this.dgv_UserData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_UserData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.col_Role});
            this.dgv_UserData.Location = new System.Drawing.Point(12, 210);
            this.dgv_UserData.MultiSelect = false;
            this.dgv_UserData.Name = "dgv_UserData";
            this.dgv_UserData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_UserData.RowHeadersVisible = false;
            this.dgv_UserData.RowTemplate.Height = 25;
            this.dgv_UserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UserData.ShowCellToolTips = false;
            this.dgv_UserData.ShowEditingIcon = false;
            this.dgv_UserData.Size = new System.Drawing.Size(732, 412);
            this.dgv_UserData.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Firstname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Lastname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Company";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // col_Role
            // 
            this.col_Role.HeaderText = "Role";
            this.col_Role.Name = "col_Role";
            this.col_Role.ReadOnly = true;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.White;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCopy.Location = new System.Drawing.Point(947, 561);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(77, 25);
            this.buttonCopy.TabIndex = 19;
            this.buttonCopy.Text = "Copy Key";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxKeyOutput
            // 
            this.textBoxKeyOutput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKeyOutput.Location = new System.Drawing.Point(831, 402);
            this.textBoxKeyOutput.Multiline = true;
            this.textBoxKeyOutput.Name = "textBoxKeyOutput";
            this.textBoxKeyOutput.ReadOnly = true;
            this.textBoxKeyOutput.Size = new System.Drawing.Size(193, 153);
            this.textBoxKeyOutput.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(876, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Invitation Key:";
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1036, 634);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKeyOutput);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.pnl_UpdateUser);
            this.Controls.Add(this.dgv_UserData);
            this.Controls.Add(this.btn_UM_Refresh);
            this.Controls.Add(this.btn_UM_DeleteUser);
            this.Controls.Add(this.btn_UM_EditUser);
            this.Controls.Add(this.lbl_UM_title);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoDesk | User Management";
            this.Load += new System.EventHandler(this.NoDesk_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.pnl_UpdateUser.ResumeLayout(false);
            this.pnl_UpdateUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserData)).EndInit();
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
        private System.Windows.Forms.Label lbl_UM_title;
        private System.Windows.Forms.Button btn_UM_EditUser;
        private System.Windows.Forms.Button btn_UM_DeleteUser;
        private System.Windows.Forms.Button btn_UM_Refresh;
        private System.Windows.Forms.Button KMBTN;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_FirstName;
        private System.Windows.Forms.ColumnHeader col_LastName;
        private System.Windows.Forms.ColumnHeader col_Email;
        private System.Windows.Forms.ColumnHeader col_Company;
        private System.Windows.Forms.Panel pnl_UpdateUser;
        private System.Windows.Forms.Button btn_UpdateUserConfirm;
        private System.Windows.Forms.TextBox txt_NewEmailInput;
        private System.Windows.Forms.Label lbl_UpdateUserEmail;
        private System.Windows.Forms.Label lbl_UpdateUserTitle;
        private System.Windows.Forms.Button btn_CancelUpdateUser;
        private System.Windows.Forms.DataGridView dgv_UserData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Role;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxKeyOutput;
        private System.Windows.Forms.Label label3;
    }
}

