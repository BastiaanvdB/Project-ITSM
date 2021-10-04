
namespace NoDeskUI
{
    partial class KeyManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyManagement));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LabelLicense = new System.Windows.Forms.Label();
            this.LabelCurrentUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.KMBTN = new System.Windows.Forms.Button();
            this.APBTN = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.UMBTN = new System.Windows.Forms.Button();
            this.IMBTN = new System.Windows.Forms.Button();
            this.DashboardBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxKeyOutput = new System.Windows.Forms.TextBox();
            this.buttonGenerateKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.listViewRegisteredCompanies = new System.Windows.Forms.ListView();
            this.columnCompany = new System.Windows.Forms.ColumnHeader();
            this.columnOwner = new System.Windows.Forms.ColumnHeader();
            this.columnemail = new System.Windows.Forms.ColumnHeader();
            this.columnTotalUsers = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.MenuPanel.Controls.Add(this.KMBTN);
            this.MenuPanel.Controls.Add(this.APBTN);
            this.MenuPanel.Controls.Add(this.buttonLogout);
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
            // KMBTN
            // 
            this.KMBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.KMBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.KMBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KMBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KMBTN.ForeColor = System.Drawing.Color.White;
            this.KMBTN.Image = global::NoDeskUI.Properties.Resources.key_6_24;
            this.KMBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KMBTN.Location = new System.Drawing.Point(679, 0);
            this.KMBTN.Name = "KMBTN";
            this.KMBTN.Size = new System.Drawing.Size(183, 41);
            this.KMBTN.TabIndex = 15;
            this.KMBTN.Text = "Key Management";
            this.KMBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KMBTN.UseVisualStyleBackColor = false;
            // 
            // APBTN
            // 
            this.APBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.APBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.APBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.APBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.APBTN.ForeColor = System.Drawing.Color.White;
            this.APBTN.Image = global::NoDeskUI.Properties.Resources.administrator_2_24;
            this.APBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.APBTN.Location = new System.Drawing.Point(532, 0);
            this.APBTN.Name = "APBTN";
            this.APBTN.Size = new System.Drawing.Size(147, 41);
            this.APBTN.TabIndex = 14;
            this.APBTN.Text = "Admin Panel";
            this.APBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.APBTN.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(956, 9);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(77, 25);
            this.buttonLogout.TabIndex = 13;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
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
            this.IMBTN.Click += new System.EventHandler(this.IMBTN_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NoDeskUI.Properties.Resources.panel_big_R;
            this.pictureBox2.Location = new System.Drawing.Point(383, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(619, 449);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NoDeskUI.Properties.Resources.panel_R;
            this.pictureBox3.Location = new System.Drawing.Point(37, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(295, 449);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(101, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 11;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCompanyName.Location = new System.Drawing.Point(67, 235);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(147, 27);
            this.textBoxCompanyName.TabIndex = 12;
            // 
            // textBoxKeyOutput
            // 
            this.textBoxKeyOutput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKeyOutput.Location = new System.Drawing.Point(67, 304);
            this.textBoxKeyOutput.Multiline = true;
            this.textBoxKeyOutput.Name = "textBoxKeyOutput";
            this.textBoxKeyOutput.Size = new System.Drawing.Size(230, 180);
            this.textBoxKeyOutput.TabIndex = 13;
            // 
            // buttonGenerateKey
            // 
            this.buttonGenerateKey.BackColor = System.Drawing.Color.White;
            this.buttonGenerateKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGenerateKey.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerateKey.Location = new System.Drawing.Point(220, 237);
            this.buttonGenerateKey.Name = "buttonGenerateKey";
            this.buttonGenerateKey.Size = new System.Drawing.Size(77, 25);
            this.buttonGenerateKey.TabIndex = 14;
            this.buttonGenerateKey.Text = "Generate";
            this.buttonGenerateKey.UseVisualStyleBackColor = false;
            this.buttonGenerateKey.Click += new System.EventHandler(this.buttonGenerateKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Company Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Activation Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(64, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Generate Activation Keys";
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.White;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCopy.Location = new System.Drawing.Point(220, 490);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(77, 25);
            this.buttonCopy.TabIndex = 18;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // listViewRegisteredCompanies
            // 
            this.listViewRegisteredCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCompany,
            this.columnOwner,
            this.columnemail,
            this.columnTotalUsers});
            this.listViewRegisteredCompanies.FullRowSelect = true;
            this.listViewRegisteredCompanies.GridLines = true;
            this.listViewRegisteredCompanies.HideSelection = false;
            this.listViewRegisteredCompanies.Location = new System.Drawing.Point(420, 235);
            this.listViewRegisteredCompanies.MultiSelect = false;
            this.listViewRegisteredCompanies.Name = "listViewRegisteredCompanies";
            this.listViewRegisteredCompanies.Size = new System.Drawing.Size(545, 249);
            this.listViewRegisteredCompanies.TabIndex = 19;
            this.listViewRegisteredCompanies.UseCompatibleStateImageBehavior = false;
            this.listViewRegisteredCompanies.View = System.Windows.Forms.View.Details;
            // 
            // columnCompany
            // 
            this.columnCompany.Text = "Company";
            this.columnCompany.Width = 100;
            // 
            // columnOwner
            // 
            this.columnOwner.Text = "Owner";
            this.columnOwner.Width = 180;
            // 
            // columnemail
            // 
            this.columnemail.Text = "Email";
            this.columnemail.Width = 180;
            // 
            // columnTotalUsers
            // 
            this.columnTotalUsers.Text = "Total Users";
            this.columnTotalUsers.Width = 80;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(888, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(420, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Registered Companies";
            // 
            // KeyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1036, 634);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewRegisteredCompanies);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGenerateKey);
            this.Controls.Add(this.textBoxKeyOutput);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeyManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoDesk | Key Management";
            this.Load += new System.EventHandler(this.NoDesk_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelCurrentUser;
        private System.Windows.Forms.Label LabelLicense;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button KMBTN;
        private System.Windows.Forms.Button APBTN;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxKeyOutput;
        private System.Windows.Forms.Button buttonGenerateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.ListView listViewRegisteredCompanies;
        private System.Windows.Forms.ColumnHeader columnCompany;
        private System.Windows.Forms.ColumnHeader columnOwner;
        private System.Windows.Forms.ColumnHeader columnemail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnTotalUsers;
    }
}

