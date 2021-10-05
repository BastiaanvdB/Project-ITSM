
namespace NoDeskUI
{
    partial class IncidentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncidentManagement));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LabelLicense = new System.Windows.Forms.Label();
            this.LabelCurrentUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonKeyManagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UMBTN = new System.Windows.Forms.Button();
            this.IMBTN = new System.Windows.Forms.Button();
            this.DashboardBTN = new System.Windows.Forms.Button();
            this.LSV_Ticketoverview = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.User = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.LBL_Ticketoverview = new System.Windows.Forms.Label();
            this.TXTBox_Search = new System.Windows.Forms.TextBox();
            this.BTN_NewTicket = new System.Windows.Forms.Button();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.TXTBOX_EmailTransfer = new System.Windows.Forms.TextBox();
            this.ComboBox_UserTransfer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Transfer = new System.Windows.Forms.Button();
            this.PNL_CreateTicket = new System.Windows.Forms.Panel();
            this.BTN_ConfirmTicket = new System.Windows.Forms.Button();
            this.ComboBox_Priority = new System.Windows.Forms.ComboBox();
            this.ComboBox_Type = new System.Windows.Forms.ComboBox();
            this.TXTBOX_Description = new System.Windows.Forms.TextBox();
            this.TXTBOX_Subject = new System.Windows.Forms.TextBox();
            this.LBL_Subject = new System.Windows.Forms.Label();
            this.LBL_Type = new System.Windows.Forms.Label();
            this.LBL_ReportedBy = new System.Windows.Forms.Label();
            this.LBL_Priority = new System.Windows.Forms.Label();
            this.LBL_Deadline = new System.Windows.Forms.Label();
            this.LBL_Description = new System.Windows.Forms.Label();
            this.LBL_CreateTicket = new System.Windows.Forms.Label();
            this.TXTBOX_User = new System.Windows.Forms.TextBox();
            this.DateTime_Deadline = new System.Windows.Forms.DateTimePicker();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.PNL_CreateTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.TopPanel.Controls.Add(this.LabelLicense);
            this.TopPanel.Controls.Add(this.LabelCurrentUser);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.MenuPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1184, 177);
            this.TopPanel.TabIndex = 0;
            // 
            // LabelLicense
            // 
            this.LabelLicense.AutoSize = true;
            this.LabelLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLicense.ForeColor = System.Drawing.Color.White;
            this.LabelLicense.Location = new System.Drawing.Point(960, 101);
            this.LabelLicense.Name = "LabelLicense";
            this.LabelLicense.Size = new System.Drawing.Size(83, 19);
            this.LabelLicense.TabIndex = 3;
            this.LabelLicense.Text = "Licensed to:";
            // 
            // LabelCurrentUser
            // 
            this.LabelCurrentUser.AutoSize = true;
            this.LabelCurrentUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelCurrentUser.ForeColor = System.Drawing.Color.White;
            this.LabelCurrentUser.Location = new System.Drawing.Point(960, 81);
            this.LabelCurrentUser.Name = "LabelCurrentUser";
            this.LabelCurrentUser.Size = new System.Drawing.Size(101, 20);
            this.LabelCurrentUser.TabIndex = 2;
            this.LabelCurrentUser.Text = "Current User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(950, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "NoDesk";
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
            this.MenuPanel.Location = new System.Drawing.Point(0, 122);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1184, 55);
            this.MenuPanel.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(1093, 12);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(88, 33);
            this.buttonLogout.TabIndex = 17;
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
            this.buttonKeyManagement.Location = new System.Drawing.Point(777, 0);
            this.buttonKeyManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKeyManagement.Name = "buttonKeyManagement";
            this.buttonKeyManagement.Size = new System.Drawing.Size(209, 55);
            this.buttonKeyManagement.TabIndex = 16;
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
            this.button1.Location = new System.Drawing.Point(609, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 55);
            this.button1.TabIndex = 15;
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
            this.UMBTN.Location = new System.Drawing.Point(395, 0);
            this.UMBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UMBTN.Name = "UMBTN";
            this.UMBTN.Size = new System.Drawing.Size(214, 55);
            this.UMBTN.TabIndex = 2;
            this.UMBTN.Text = "User Management";
            this.UMBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UMBTN.UseVisualStyleBackColor = false;
            this.UMBTN.Click += new System.EventHandler(this.UMBTN_Click);
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
            this.IMBTN.Location = new System.Drawing.Point(150, 0);
            this.IMBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IMBTN.Name = "IMBTN";
            this.IMBTN.Size = new System.Drawing.Size(245, 55);
            this.IMBTN.TabIndex = 1;
            this.IMBTN.Text = "Incident Management";
            this.IMBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IMBTN.UseVisualStyleBackColor = false;
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
            this.DashboardBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DashboardBTN.Name = "DashboardBTN";
            this.DashboardBTN.Size = new System.Drawing.Size(150, 55);
            this.DashboardBTN.TabIndex = 0;
            this.DashboardBTN.Text = "Dashboard";
            this.DashboardBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardBTN.UseVisualStyleBackColor = false;
            this.DashboardBTN.Click += new System.EventHandler(this.DashboardBTN_Click);
            // 
            // LSV_Ticketoverview
            // 
            this.LSV_Ticketoverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.User,
            this.Email,
            this.Date,
            this.Status});
            this.LSV_Ticketoverview.HideSelection = false;
            this.LSV_Ticketoverview.Location = new System.Drawing.Point(87, 316);
            this.LSV_Ticketoverview.Name = "LSV_Ticketoverview";
            this.LSV_Ticketoverview.Size = new System.Drawing.Size(626, 517);
            this.LSV_Ticketoverview.TabIndex = 1;
            this.LSV_Ticketoverview.UseCompatibleStateImageBehavior = false;
            this.LSV_Ticketoverview.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // User
            // 
            this.User.Text = "User";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // LBL_Ticketoverview
            // 
            this.LBL_Ticketoverview.AutoSize = true;
            this.LBL_Ticketoverview.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Ticketoverview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Ticketoverview.Location = new System.Drawing.Point(78, 189);
            this.LBL_Ticketoverview.Name = "LBL_Ticketoverview";
            this.LBL_Ticketoverview.Size = new System.Drawing.Size(263, 45);
            this.LBL_Ticketoverview.TabIndex = 2;
            this.LBL_Ticketoverview.Text = "Ticket overview";
            // 
            // TXTBox_Search
            // 
            this.TXTBox_Search.Location = new System.Drawing.Point(87, 257);
            this.TXTBox_Search.Name = "TXTBox_Search";
            this.TXTBox_Search.Size = new System.Drawing.Size(175, 27);
            this.TXTBox_Search.TabIndex = 3;
            this.TXTBox_Search.Text = "Email";
            // 
            // BTN_NewTicket
            // 
            this.BTN_NewTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.BTN_NewTicket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_NewTicket.Location = new System.Drawing.Point(549, 256);
            this.BTN_NewTicket.Name = "BTN_NewTicket";
            this.BTN_NewTicket.Size = new System.Drawing.Size(165, 29);
            this.BTN_NewTicket.TabIndex = 5;
            this.BTN_NewTicket.Text = "New Ticket";
            this.BTN_NewTicket.UseVisualStyleBackColor = false;
            // 
            // BTN_Search
            // 
            this.BTN_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.BTN_Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Search.Location = new System.Drawing.Point(285, 256);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(94, 29);
            this.BTN_Search.TabIndex = 6;
            this.BTN_Search.Text = "Search";
            this.BTN_Search.UseVisualStyleBackColor = false;
            // 
            // TXTBOX_EmailTransfer
            // 
            this.TXTBOX_EmailTransfer.Location = new System.Drawing.Point(741, 453);
            this.TXTBOX_EmailTransfer.Name = "TXTBOX_EmailTransfer";
            this.TXTBOX_EmailTransfer.Size = new System.Drawing.Size(151, 27);
            this.TXTBOX_EmailTransfer.TabIndex = 7;
            this.TXTBOX_EmailTransfer.Text = "Email";
            // 
            // ComboBox_UserTransfer
            // 
            this.ComboBox_UserTransfer.FormattingEnabled = true;
            this.ComboBox_UserTransfer.Location = new System.Drawing.Point(741, 407);
            this.ComboBox_UserTransfer.Name = "ComboBox_UserTransfer";
            this.ComboBox_UserTransfer.Size = new System.Drawing.Size(151, 28);
            this.ComboBox_UserTransfer.TabIndex = 8;
            this.ComboBox_UserTransfer.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(730, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Transfer ticket to other user";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(741, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select incident you would like to transfer";
            // 
            // BTN_Transfer
            // 
            this.BTN_Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.BTN_Transfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Transfer.Location = new System.Drawing.Point(960, 407);
            this.BTN_Transfer.Name = "BTN_Transfer";
            this.BTN_Transfer.Size = new System.Drawing.Size(144, 73);
            this.BTN_Transfer.TabIndex = 11;
            this.BTN_Transfer.Text = "Transfer Ticket";
            this.BTN_Transfer.UseVisualStyleBackColor = false;
            // 
            // PNL_CreateTicket
            // 
            this.PNL_CreateTicket.Controls.Add(this.DateTime_Deadline);
            this.PNL_CreateTicket.Controls.Add(this.TXTBOX_User);
            this.PNL_CreateTicket.Controls.Add(this.BTN_ConfirmTicket);
            this.PNL_CreateTicket.Controls.Add(this.ComboBox_Priority);
            this.PNL_CreateTicket.Controls.Add(this.ComboBox_Type);
            this.PNL_CreateTicket.Controls.Add(this.TXTBOX_Description);
            this.PNL_CreateTicket.Controls.Add(this.TXTBOX_Subject);
            this.PNL_CreateTicket.Controls.Add(this.LBL_Subject);
            this.PNL_CreateTicket.Controls.Add(this.LBL_Type);
            this.PNL_CreateTicket.Controls.Add(this.LBL_ReportedBy);
            this.PNL_CreateTicket.Controls.Add(this.LBL_Priority);
            this.PNL_CreateTicket.Controls.Add(this.LBL_Deadline);
            this.PNL_CreateTicket.Controls.Add(this.LBL_Description);
            this.PNL_CreateTicket.Controls.Add(this.LBL_CreateTicket);
            this.PNL_CreateTicket.Location = new System.Drawing.Point(210, 189);
            this.PNL_CreateTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PNL_CreateTicket.Name = "PNL_CreateTicket";
            this.PNL_CreateTicket.Size = new System.Drawing.Size(589, 813);
            this.PNL_CreateTicket.TabIndex = 12;
            // 
            // BTN_ConfirmTicket
            // 
            this.BTN_ConfirmTicket.Location = new System.Drawing.Point(136, 508);
            this.BTN_ConfirmTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_ConfirmTicket.Name = "BTN_ConfirmTicket";
            this.BTN_ConfirmTicket.Size = new System.Drawing.Size(289, 37);
            this.BTN_ConfirmTicket.TabIndex = 15;
            this.BTN_ConfirmTicket.Text = "Create Incident Ticket";
            this.BTN_ConfirmTicket.UseVisualStyleBackColor = true;
            // 
            // ComboBox_Priority
            // 
            this.ComboBox_Priority.FormattingEnabled = true;
            this.ComboBox_Priority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.ComboBox_Priority.Location = new System.Drawing.Point(226, 319);
            this.ComboBox_Priority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_Priority.Name = "ComboBox_Priority";
            this.ComboBox_Priority.Size = new System.Drawing.Size(263, 28);
            this.ComboBox_Priority.TabIndex = 13;
            // 
            // ComboBox_Type
            // 
            this.ComboBox_Type.FormattingEnabled = true;
            this.ComboBox_Type.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Service"});
            this.ComboBox_Type.Location = new System.Drawing.Point(226, 213);
            this.ComboBox_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_Type.Name = "ComboBox_Type";
            this.ComboBox_Type.Size = new System.Drawing.Size(263, 28);
            this.ComboBox_Type.TabIndex = 11;
            // 
            // TXTBOX_Description
            // 
            this.TXTBOX_Description.Location = new System.Drawing.Point(226, 414);
            this.TXTBOX_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTBOX_Description.Name = "TXTBOX_Description";
            this.TXTBOX_Description.Size = new System.Drawing.Size(263, 27);
            this.TXTBOX_Description.TabIndex = 10;
            // 
            // TXTBOX_Subject
            // 
            this.TXTBOX_Subject.Location = new System.Drawing.Point(226, 162);
            this.TXTBOX_Subject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTBOX_Subject.Name = "TXTBOX_Subject";
            this.TXTBOX_Subject.Size = new System.Drawing.Size(263, 27);
            this.TXTBOX_Subject.TabIndex = 9;
            // 
            // LBL_Subject
            // 
            this.LBL_Subject.AutoSize = true;
            this.LBL_Subject.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Subject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Subject.Location = new System.Drawing.Point(49, 166);
            this.LBL_Subject.Name = "LBL_Subject";
            this.LBL_Subject.Size = new System.Drawing.Size(136, 20);
            this.LBL_Subject.TabIndex = 7;
            this.LBL_Subject.Text = "Subject of incident";
            // 
            // LBL_Type
            // 
            this.LBL_Type.AutoSize = true;
            this.LBL_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Type.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Type.Location = new System.Drawing.Point(49, 215);
            this.LBL_Type.Name = "LBL_Type";
            this.LBL_Type.Size = new System.Drawing.Size(118, 20);
            this.LBL_Type.TabIndex = 6;
            this.LBL_Type.Text = "Type of incident";
            // 
            // LBL_ReportedBy
            // 
            this.LBL_ReportedBy.AutoSize = true;
            this.LBL_ReportedBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_ReportedBy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_ReportedBy.Location = new System.Drawing.Point(49, 270);
            this.LBL_ReportedBy.Name = "LBL_ReportedBy";
            this.LBL_ReportedBy.Size = new System.Drawing.Size(126, 20);
            this.LBL_ReportedBy.TabIndex = 5;
            this.LBL_ReportedBy.Text = "Reported by user";
            // 
            // LBL_Priority
            // 
            this.LBL_Priority.AutoSize = true;
            this.LBL_Priority.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Priority.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Priority.Location = new System.Drawing.Point(49, 323);
            this.LBL_Priority.Name = "LBL_Priority";
            this.LBL_Priority.Size = new System.Drawing.Size(60, 20);
            this.LBL_Priority.TabIndex = 4;
            this.LBL_Priority.Text = "Priority";
            // 
            // LBL_Deadline
            // 
            this.LBL_Deadline.AutoSize = true;
            this.LBL_Deadline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Deadline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Deadline.Location = new System.Drawing.Point(49, 371);
            this.LBL_Deadline.Name = "LBL_Deadline";
            this.LBL_Deadline.Size = new System.Drawing.Size(70, 20);
            this.LBL_Deadline.TabIndex = 3;
            this.LBL_Deadline.Text = "Deadline";
            // 
            // LBL_Description
            // 
            this.LBL_Description.AutoSize = true;
            this.LBL_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Description.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Description.Location = new System.Drawing.Point(49, 418);
            this.LBL_Description.Name = "LBL_Description";
            this.LBL_Description.Size = new System.Drawing.Size(87, 20);
            this.LBL_Description.TabIndex = 2;
            this.LBL_Description.Text = "Description";
            // 
            // LBL_CreateTicket
            // 
            this.LBL_CreateTicket.AutoSize = true;
            this.LBL_CreateTicket.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_CreateTicket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_CreateTicket.Location = new System.Drawing.Point(96, 49);
            this.LBL_CreateTicket.Name = "LBL_CreateTicket";
            this.LBL_CreateTicket.Size = new System.Drawing.Size(386, 41);
            this.LBL_CreateTicket.TabIndex = 0;
            this.LBL_CreateTicket.Text = "Create new incident ticket";
            // 
            // TXTBOX_User
            // 
            this.TXTBOX_User.Location = new System.Drawing.Point(226, 267);
            this.TXTBOX_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTBOX_User.Name = "TXTBOX_User";
            this.TXTBOX_User.Size = new System.Drawing.Size(263, 27);
            this.TXTBOX_User.TabIndex = 16;
            // 
            // DateTime_Deadline
            // 
            this.DateTime_Deadline.Location = new System.Drawing.Point(226, 371);
            this.DateTime_Deadline.MaxDate = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            this.DateTime_Deadline.MinDate = new System.DateTime(2021, 10, 5, 0, 0, 0, 0);
            this.DateTime_Deadline.Name = "DateTime_Deadline";
            this.DateTime_Deadline.Size = new System.Drawing.Size(263, 27);
            this.DateTime_Deadline.TabIndex = 17;
            this.DateTime_Deadline.Value = new System.DateTime(2021, 10, 5, 0, 0, 0, 0);
            // 
            // IncidentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1184, 845);
            this.Controls.Add(this.PNL_CreateTicket);
            this.Controls.Add(this.BTN_Transfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox_UserTransfer);
            this.Controls.Add(this.TXTBOX_EmailTransfer);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.BTN_NewTicket);
            this.Controls.Add(this.TXTBox_Search);
            this.Controls.Add(this.LBL_Ticketoverview);
            this.Controls.Add(this.LSV_Ticketoverview);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IncidentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoDesk | Incident Management";
            this.Load += new System.EventHandler(this.NoDesk_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.PNL_CreateTicket.ResumeLayout(false);
            this.PNL_CreateTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button IMBTN;
        private System.Windows.Forms.Button DashboardBTN;
        private System.Windows.Forms.Button UMBTN;
        private System.Windows.Forms.Label LabelCurrentUser;
        private System.Windows.Forms.Label LabelLicense;
        private System.Windows.Forms.ListView LSV_Ticketoverview;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Label LBL_Ticketoverview;
        private System.Windows.Forms.TextBox TXTBox_Search;
        private System.Windows.Forms.Button BTN_NewTicket;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.TextBox TXTBOX_EmailTransfer;
        private System.Windows.Forms.ComboBox ComboBox_UserTransfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Transfer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonKeyManagement;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel PNL_CreateTicket;
        private System.Windows.Forms.Button BTN_ConfirmTicket;
        private System.Windows.Forms.ComboBox ComboBox_Priority;
        private System.Windows.Forms.ComboBox ComboBox_Type;
        private System.Windows.Forms.TextBox TXTBOX_Description;
        private System.Windows.Forms.TextBox TXTBOX_Subject;
        private System.Windows.Forms.Label LBL_Subject;
        private System.Windows.Forms.Label LBL_Type;
        private System.Windows.Forms.Label LBL_ReportedBy;
        private System.Windows.Forms.Label LBL_Priority;
        private System.Windows.Forms.Label LBL_Deadline;
        private System.Windows.Forms.Label LBL_Description;
        private System.Windows.Forms.Label LBL_CreateTicket;
        private System.Windows.Forms.DateTimePicker DateTime_Deadline;
        private System.Windows.Forms.TextBox TXTBOX_User;
    }
}

