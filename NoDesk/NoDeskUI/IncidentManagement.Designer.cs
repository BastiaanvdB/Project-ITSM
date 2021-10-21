
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncidentManagement));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LabelLicense = new System.Windows.Forms.Label();
            this.LabelCurrentUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.KMBTN = new System.Windows.Forms.Button();
            this.UMBTN = new System.Windows.Forms.Button();
            this.IMBTN = new System.Windows.Forms.Button();
            this.DashboardBTN = new System.Windows.Forms.Button();
            this.LBL_Ticketoverview = new System.Windows.Forms.Label();
            this.TXTBox_Search = new System.Windows.Forms.TextBox();
            this.BTN_NewTicket = new System.Windows.Forms.Button();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Transfer = new System.Windows.Forms.Button();
            this.PNL_CreateTicket = new System.Windows.Forms.Panel();
            this.BTN_CloseNewIncident = new System.Windows.Forms.Button();
            this.DateTime_Deadline = new System.Windows.Forms.DateTimePicker();
            this.BTN_ConfirmTicket = new System.Windows.Forms.Button();
            this.ComboBox_Priority = new System.Windows.Forms.ComboBox();
            this.ComboBox_Type = new System.Windows.Forms.ComboBox();
            this.TXTBOX_Description = new System.Windows.Forms.TextBox();
            this.TXTBOX_Subject = new System.Windows.Forms.TextBox();
            this.LBL_Subject = new System.Windows.Forms.Label();
            this.LBL_Type = new System.Windows.Forms.Label();
            this.LBL_Priority = new System.Windows.Forms.Label();
            this.LBL_Deadline = new System.Windows.Forms.Label();
            this.LBL_Description = new System.Windows.Forms.Label();
            this.LBL_CreateTicket = new System.Windows.Forms.Label();
            this.LBL_Transfertouser = new System.Windows.Forms.Label();
            this.DGV_Incidents = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBL_SelectIncident = new System.Windows.Forms.Label();
            this.LBL_ChangeStatus = new System.Windows.Forms.Label();
            this.BTN_ChangeStatus = new System.Windows.Forms.Button();
            this.ComboBox_UserTransfer = new System.Windows.Forms.ComboBox();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.PNL_CreateTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Incidents)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(831, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "NoDesk";
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
            this.buttonLogout.TabIndex = 17;
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
            this.KMBTN.TabIndex = 16;
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
            this.IMBTN.Location = new System.Drawing.Point(131, 0);
            this.IMBTN.Name = "IMBTN";
            this.IMBTN.Size = new System.Drawing.Size(214, 41);
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
            this.DashboardBTN.Name = "DashboardBTN";
            this.DashboardBTN.Size = new System.Drawing.Size(131, 41);
            this.DashboardBTN.TabIndex = 0;
            this.DashboardBTN.Text = "Dashboard";
            this.DashboardBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DashboardBTN.UseVisualStyleBackColor = false;
            this.DashboardBTN.Click += new System.EventHandler(this.DashboardBTN_Click);
            // 
            // LBL_Ticketoverview
            // 
            this.LBL_Ticketoverview.AutoSize = true;
            this.LBL_Ticketoverview.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Ticketoverview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Ticketoverview.Location = new System.Drawing.Point(12, 153);
            this.LBL_Ticketoverview.Name = "LBL_Ticketoverview";
            this.LBL_Ticketoverview.Size = new System.Drawing.Size(221, 37);
            this.LBL_Ticketoverview.TabIndex = 2;
            this.LBL_Ticketoverview.Text = "Ticket overview";
            // 
            // TXTBox_Search
            // 
            this.TXTBox_Search.Location = new System.Drawing.Point(12, 214);
            this.TXTBox_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTBox_Search.Name = "TXTBox_Search";
            this.TXTBox_Search.Size = new System.Drawing.Size(179, 23);
            this.TXTBox_Search.TabIndex = 3;
            this.TXTBox_Search.Text = "User";
            // 
            // BTN_NewTicket
            // 
            this.BTN_NewTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.BTN_NewTicket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_NewTicket.Location = new System.Drawing.Point(513, 213);
            this.BTN_NewTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_NewTicket.Name = "BTN_NewTicket";
            this.BTN_NewTicket.Size = new System.Drawing.Size(169, 22);
            this.BTN_NewTicket.TabIndex = 5;
            this.BTN_NewTicket.Text = "New Ticket";
            this.BTN_NewTicket.UseVisualStyleBackColor = false;
            this.BTN_NewTicket.Click += new System.EventHandler(this.BTN_NewTicket_Click);
            // 
            // BTN_Search
            // 
            this.BTN_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.BTN_Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Search.Location = new System.Drawing.Point(185, 213);
            this.BTN_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(107, 22);
            this.BTN_Search.TabIndex = 6;
            this.BTN_Search.Text = "Search";
            this.BTN_Search.UseVisualStyleBackColor = false;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(679, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Transfer ticket to other user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(688, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select incident you would like to transfer";
            // 
            // BTN_Transfer
            // 
            this.BTN_Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.BTN_Transfer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Transfer.Location = new System.Drawing.Point(924, 289);
            this.BTN_Transfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Transfer.Name = "BTN_Transfer";
            this.BTN_Transfer.Size = new System.Drawing.Size(100, 42);
            this.BTN_Transfer.TabIndex = 11;
            this.BTN_Transfer.Text = "Transfer Ticket";
            this.BTN_Transfer.UseVisualStyleBackColor = false;
            this.BTN_Transfer.Click += new System.EventHandler(this.BTN_Transfer_Click);
            // 
            // PNL_CreateTicket
            // 
            this.PNL_CreateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.PNL_CreateTicket.Controls.Add(this.BTN_CloseNewIncident);
            this.PNL_CreateTicket.Controls.Add(this.DateTime_Deadline);
            this.PNL_CreateTicket.Controls.Add(this.BTN_ConfirmTicket);
            this.PNL_CreateTicket.Controls.Add(this.ComboBox_Priority);
            this.PNL_CreateTicket.Controls.Add(this.ComboBox_Type);
            this.PNL_CreateTicket.Controls.Add(this.TXTBOX_Description);
            this.PNL_CreateTicket.Controls.Add(this.TXTBOX_Subject);
            this.PNL_CreateTicket.Controls.Add(this.LBL_Subject);
            this.PNL_CreateTicket.Controls.Add(this.LBL_Type);
            this.PNL_CreateTicket.Controls.Add(this.LBL_Priority);
            this.PNL_CreateTicket.Controls.Add(this.LBL_Deadline);
            this.PNL_CreateTicket.Controls.Add(this.LBL_Description);
            this.PNL_CreateTicket.Controls.Add(this.LBL_CreateTicket);
            this.PNL_CreateTicket.Location = new System.Drawing.Point(263, 153);
            this.PNL_CreateTicket.Name = "PNL_CreateTicket";
            this.PNL_CreateTicket.Size = new System.Drawing.Size(515, 610);
            this.PNL_CreateTicket.TabIndex = 12;
            // 
            // BTN_CloseNewIncident
            // 
            this.BTN_CloseNewIncident.BackColor = System.Drawing.Color.White;
            this.BTN_CloseNewIncident.ForeColor = System.Drawing.Color.Red;
            this.BTN_CloseNewIncident.Location = new System.Drawing.Point(471, 14);
            this.BTN_CloseNewIncident.Name = "BTN_CloseNewIncident";
            this.BTN_CloseNewIncident.Size = new System.Drawing.Size(28, 23);
            this.BTN_CloseNewIncident.TabIndex = 18;
            this.BTN_CloseNewIncident.Text = "X";
            this.BTN_CloseNewIncident.UseVisualStyleBackColor = false;
            this.BTN_CloseNewIncident.Click += new System.EventHandler(this.BTN_CloseNewIncident_Click);
            // 
            // DateTime_Deadline
            // 
            this.DateTime_Deadline.Location = new System.Drawing.Point(198, 236);
            this.DateTime_Deadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTime_Deadline.MaxDate = new System.DateTime(2025, 10, 5, 0, 0, 0, 0);
            this.DateTime_Deadline.MinDate = new System.DateTime(2021, 10, 18, 20, 55, 54, 0);
            this.DateTime_Deadline.Name = "DateTime_Deadline";
            this.DateTime_Deadline.Size = new System.Drawing.Size(231, 23);
            this.DateTime_Deadline.TabIndex = 17;
            this.DateTime_Deadline.Value = new System.DateTime(2021, 10, 18, 20, 55, 54, 0);
            // 
            // BTN_ConfirmTicket
            // 
            this.BTN_ConfirmTicket.BackColor = System.Drawing.Color.White;
            this.BTN_ConfirmTicket.Location = new System.Drawing.Point(132, 377);
            this.BTN_ConfirmTicket.Name = "BTN_ConfirmTicket";
            this.BTN_ConfirmTicket.Size = new System.Drawing.Size(253, 28);
            this.BTN_ConfirmTicket.TabIndex = 15;
            this.BTN_ConfirmTicket.Text = "Create Incident Ticket";
            this.BTN_ConfirmTicket.UseVisualStyleBackColor = false;
            this.BTN_ConfirmTicket.Click += new System.EventHandler(this.BTN_ConfirmTicket_Click);
            // 
            // ComboBox_Priority
            // 
            this.ComboBox_Priority.FormattingEnabled = true;
            this.ComboBox_Priority.Location = new System.Drawing.Point(198, 197);
            this.ComboBox_Priority.Name = "ComboBox_Priority";
            this.ComboBox_Priority.Size = new System.Drawing.Size(231, 23);
            this.ComboBox_Priority.TabIndex = 13;
            // 
            // ComboBox_Type
            // 
            this.ComboBox_Type.FormattingEnabled = true;
            this.ComboBox_Type.Location = new System.Drawing.Point(198, 160);
            this.ComboBox_Type.Name = "ComboBox_Type";
            this.ComboBox_Type.Size = new System.Drawing.Size(231, 23);
            this.ComboBox_Type.TabIndex = 11;
            // 
            // TXTBOX_Description
            // 
            this.TXTBOX_Description.Location = new System.Drawing.Point(198, 268);
            this.TXTBOX_Description.Name = "TXTBOX_Description";
            this.TXTBOX_Description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXTBOX_Description.Size = new System.Drawing.Size(231, 23);
            this.TXTBOX_Description.TabIndex = 10;
            // 
            // TXTBOX_Subject
            // 
            this.TXTBOX_Subject.Location = new System.Drawing.Point(198, 122);
            this.TXTBOX_Subject.Name = "TXTBOX_Subject";
            this.TXTBOX_Subject.Size = new System.Drawing.Size(231, 23);
            this.TXTBOX_Subject.TabIndex = 9;
            // 
            // LBL_Subject
            // 
            this.LBL_Subject.AutoSize = true;
            this.LBL_Subject.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Subject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Subject.Location = new System.Drawing.Point(43, 124);
            this.LBL_Subject.Name = "LBL_Subject";
            this.LBL_Subject.Size = new System.Drawing.Size(107, 15);
            this.LBL_Subject.TabIndex = 7;
            this.LBL_Subject.Text = "Subject of incident";
            // 
            // LBL_Type
            // 
            this.LBL_Type.AutoSize = true;
            this.LBL_Type.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Type.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Type.Location = new System.Drawing.Point(43, 161);
            this.LBL_Type.Name = "LBL_Type";
            this.LBL_Type.Size = new System.Drawing.Size(92, 15);
            this.LBL_Type.TabIndex = 6;
            this.LBL_Type.Text = "Type of incident";
            // 
            // LBL_Priority
            // 
            this.LBL_Priority.AutoSize = true;
            this.LBL_Priority.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Priority.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Priority.Location = new System.Drawing.Point(43, 200);
            this.LBL_Priority.Name = "LBL_Priority";
            this.LBL_Priority.Size = new System.Drawing.Size(45, 15);
            this.LBL_Priority.TabIndex = 4;
            this.LBL_Priority.Text = "Priority";
            // 
            // LBL_Deadline
            // 
            this.LBL_Deadline.AutoSize = true;
            this.LBL_Deadline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Deadline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Deadline.Location = new System.Drawing.Point(43, 236);
            this.LBL_Deadline.Name = "LBL_Deadline";
            this.LBL_Deadline.Size = new System.Drawing.Size(54, 15);
            this.LBL_Deadline.TabIndex = 3;
            this.LBL_Deadline.Text = "Deadline";
            // 
            // LBL_Description
            // 
            this.LBL_Description.AutoSize = true;
            this.LBL_Description.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Description.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Description.Location = new System.Drawing.Point(43, 272);
            this.LBL_Description.Name = "LBL_Description";
            this.LBL_Description.Size = new System.Drawing.Size(68, 15);
            this.LBL_Description.TabIndex = 2;
            this.LBL_Description.Text = "Description";
            // 
            // LBL_CreateTicket
            // 
            this.LBL_CreateTicket.AutoSize = true;
            this.LBL_CreateTicket.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_CreateTicket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_CreateTicket.Location = new System.Drawing.Point(84, 37);
            this.LBL_CreateTicket.Name = "LBL_CreateTicket";
            this.LBL_CreateTicket.Size = new System.Drawing.Size(311, 32);
            this.LBL_CreateTicket.TabIndex = 0;
            this.LBL_CreateTicket.Text = "Create new incident ticket";
            // 
            // LBL_Transfertouser
            // 
            this.LBL_Transfertouser.AutoSize = true;
            this.LBL_Transfertouser.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Transfertouser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Transfertouser.Location = new System.Drawing.Point(687, 303);
            this.LBL_Transfertouser.Name = "LBL_Transfertouser";
            this.LBL_Transfertouser.Size = new System.Drawing.Size(91, 15);
            this.LBL_Transfertouser.TabIndex = 14;
            this.LBL_Transfertouser.Text = "Transfer to user:";
            // 
            // DGV_Incidents
            // 
            this.DGV_Incidents.AllowUserToAddRows = false;
            this.DGV_Incidents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGV_Incidents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Incidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Incidents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Subject,
            this.ColumnUser,
            this.Column_Priority,
            this.ColumnDeadline,
            this.Column_Status,
            this.Column_Text});
            this.DGV_Incidents.Location = new System.Drawing.Point(12, 239);
            this.DGV_Incidents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_Incidents.Name = "DGV_Incidents";
            this.DGV_Incidents.ReadOnly = true;
            this.DGV_Incidents.RowHeadersVisible = false;
            this.DGV_Incidents.RowHeadersWidth = 51;
            this.DGV_Incidents.RowTemplate.Height = 29;
            this.DGV_Incidents.ShowCellToolTips = false;
            this.DGV_Incidents.ShowEditingIcon = false;
            this.DGV_Incidents.Size = new System.Drawing.Size(670, 378);
            this.DGV_Incidents.TabIndex = 15;
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.MinimumWidth = 6;
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Width = 125;
            // 
            // Column_Subject
            // 
            this.Column_Subject.HeaderText = "Subject";
            this.Column_Subject.MinimumWidth = 6;
            this.Column_Subject.Name = "Column_Subject";
            this.Column_Subject.ReadOnly = true;
            this.Column_Subject.Width = 125;
            // 
            // ColumnUser
            // 
            this.ColumnUser.HeaderText = "User";
            this.ColumnUser.MinimumWidth = 6;
            this.ColumnUser.Name = "ColumnUser";
            this.ColumnUser.ReadOnly = true;
            this.ColumnUser.Width = 125;
            // 
            // Column_Priority
            // 
            this.Column_Priority.HeaderText = "Priority";
            this.Column_Priority.MinimumWidth = 6;
            this.Column_Priority.Name = "Column_Priority";
            this.Column_Priority.ReadOnly = true;
            this.Column_Priority.Width = 125;
            // 
            // ColumnDeadline
            // 
            this.ColumnDeadline.HeaderText = "Deadline";
            this.ColumnDeadline.MinimumWidth = 6;
            this.ColumnDeadline.Name = "ColumnDeadline";
            this.ColumnDeadline.ReadOnly = true;
            this.ColumnDeadline.Width = 125;
            // 
            // Column_Status
            // 
            this.Column_Status.HeaderText = "Status";
            this.Column_Status.MinimumWidth = 6;
            this.Column_Status.Name = "Column_Status";
            this.Column_Status.ReadOnly = true;
            this.Column_Status.Width = 125;
            // 
            // Column_Text
            // 
            this.Column_Text.HeaderText = "Description";
            this.Column_Text.MinimumWidth = 6;
            this.Column_Text.Name = "Column_Text";
            this.Column_Text.ReadOnly = true;
            this.Column_Text.Width = 125;
            // 
            // LBL_SelectIncident
            // 
            this.LBL_SelectIncident.AutoSize = true;
            this.LBL_SelectIncident.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_SelectIncident.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_SelectIncident.Location = new System.Drawing.Point(698, 378);
            this.LBL_SelectIncident.Name = "LBL_SelectIncident";
            this.LBL_SelectIncident.Size = new System.Drawing.Size(184, 15);
            this.LBL_SelectIncident.TabIndex = 17;
            this.LBL_SelectIncident.Text = "Select incident and change status";
            // 
            // LBL_ChangeStatus
            // 
            this.LBL_ChangeStatus.AutoSize = true;
            this.LBL_ChangeStatus.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_ChangeStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_ChangeStatus.Location = new System.Drawing.Point(688, 349);
            this.LBL_ChangeStatus.Name = "LBL_ChangeStatus";
            this.LBL_ChangeStatus.Size = new System.Drawing.Size(258, 31);
            this.LBL_ChangeStatus.TabIndex = 16;
            this.LBL_ChangeStatus.Text = "Change status incident";
            // 
            // BTN_ChangeStatus
            // 
            this.BTN_ChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.BTN_ChangeStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_ChangeStatus.Location = new System.Drawing.Point(698, 409);
            this.BTN_ChangeStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ChangeStatus.Name = "BTN_ChangeStatus";
            this.BTN_ChangeStatus.Size = new System.Drawing.Size(326, 42);
            this.BTN_ChangeStatus.TabIndex = 18;
            this.BTN_ChangeStatus.Text = "Change status to \"Closed\"";
            this.BTN_ChangeStatus.UseVisualStyleBackColor = false;
            this.BTN_ChangeStatus.Click += new System.EventHandler(this.BTN_ChangeStatus_Click);
            // 
            // ComboBox_UserTransfer
            // 
            this.ComboBox_UserTransfer.FormattingEnabled = true;
            this.ComboBox_UserTransfer.Location = new System.Drawing.Point(784, 300);
            this.ComboBox_UserTransfer.Name = "ComboBox_UserTransfer";
            this.ComboBox_UserTransfer.Size = new System.Drawing.Size(134, 23);
            this.ComboBox_UserTransfer.TabIndex = 19;
            // 
            // IncidentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1036, 634);
            this.Controls.Add(this.ComboBox_UserTransfer);
            this.Controls.Add(this.PNL_CreateTicket);
            this.Controls.Add(this.BTN_ChangeStatus);
            this.Controls.Add(this.LBL_SelectIncident);
            this.Controls.Add(this.LBL_ChangeStatus);
            this.Controls.Add(this.DGV_Incidents);
            this.Controls.Add(this.BTN_Transfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.BTN_NewTicket);
            this.Controls.Add(this.TXTBox_Search);
            this.Controls.Add(this.LBL_Ticketoverview);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LBL_Transfertouser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IncidentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoDesk | Incident Management";
            this.Load += new System.EventHandler(this.NoDesk_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.PNL_CreateTicket.ResumeLayout(false);
            this.PNL_CreateTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Incidents)).EndInit();
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
        private System.Windows.Forms.Label LBL_Ticketoverview;
        private System.Windows.Forms.TextBox TXTBox_Search;
        private System.Windows.Forms.Button BTN_NewTicket;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Transfer;
        private System.Windows.Forms.Button KMBTN;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel PNL_CreateTicket;
        private System.Windows.Forms.Button BTN_ConfirmTicket;
        private System.Windows.Forms.ComboBox ComboBox_Priority;
        private System.Windows.Forms.ComboBox ComboBox_Type;
        private System.Windows.Forms.TextBox TXTBOX_Description;
        private System.Windows.Forms.TextBox TXTBOX_Subject;
        private System.Windows.Forms.Label LBL_Subject;
        private System.Windows.Forms.Label LBL_Type;
        private System.Windows.Forms.Label LBL_Priority;
        private System.Windows.Forms.Label LBL_Deadline;
        private System.Windows.Forms.Label LBL_Description;
        private System.Windows.Forms.Label LBL_CreateTicket;
        private System.Windows.Forms.DateTimePicker DateTime_Deadline;
        private System.Windows.Forms.Button BTN_CloseNewIncident;
        private System.Windows.Forms.Label LBL_Transfertouser;
        private System.Windows.Forms.DataGridView DGV_Incidents;
        private System.Windows.Forms.Label LBL_SelectIncident;
        private System.Windows.Forms.Label LBL_ChangeStatus;
        private System.Windows.Forms.Button BTN_ChangeStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Text;
        private System.Windows.Forms.ComboBox ComboBox_UserTransfer;
    }
}

