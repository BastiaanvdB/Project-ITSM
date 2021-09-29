
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
            this.UMBTN = new System.Windows.Forms.Button();
            this.IMBTN = new System.Windows.Forms.Button();
            this.DashboardBTN = new System.Windows.Forms.Button();
            this.LSV_Ticketoverview = new System.Windows.Forms.ListView();
            this.LBL_Ticketoverview = new System.Windows.Forms.Label();
            this.TXTBox_Search = new System.Windows.Forms.TextBox();
            this.BTN_NewTicket = new System.Windows.Forms.Button();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.User = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.TXTBOX_EmailTransfer = new System.Windows.Forms.TextBox();
            this.ComboBox_UserTransfer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Transfer = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
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
            // LBL_Ticketoverview
            // 
            this.LBL_Ticketoverview.AutoSize = true;
            this.LBL_Ticketoverview.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Ticketoverview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Ticketoverview.Location = new System.Drawing.Point(78, 190);
            this.LBL_Ticketoverview.Name = "LBL_Ticketoverview";
            this.LBL_Ticketoverview.Size = new System.Drawing.Size(270, 46);
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
            this.BTN_NewTicket.Size = new System.Drawing.Size(164, 29);
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
            // TXTBOX_EmailTransfer
            // 
            this.TXTBOX_EmailTransfer.Location = new System.Drawing.Point(740, 453);
            this.TXTBOX_EmailTransfer.Name = "TXTBOX_EmailTransfer";
            this.TXTBOX_EmailTransfer.Size = new System.Drawing.Size(151, 27);
            this.TXTBOX_EmailTransfer.TabIndex = 7;
            this.TXTBOX_EmailTransfer.Text = "Email";
            // 
            // ComboBox_UserTransfer
            // 
            this.ComboBox_UserTransfer.FormattingEnabled = true;
            this.ComboBox_UserTransfer.Location = new System.Drawing.Point(740, 407);
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
            this.label3.Location = new System.Drawing.Point(740, 354);
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
            // IncidentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1184, 845);
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
    }
}

