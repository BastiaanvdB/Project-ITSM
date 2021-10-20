
namespace NoDeskUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TextboxUsername = new System.Windows.Forms.TextBox();
            this.TextboxPassword = new System.Windows.Forms.TextBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkLabelR = new System.Windows.Forms.LinkLabel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelRegistration = new System.Windows.Forms.Panel();
            this.buttonReturnLogin = new System.Windows.Forms.Button();
            this.groupBoxCompany = new System.Windows.Forms.GroupBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegPasswordretry = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.txtRegLastname = new System.Windows.Forms.TextBox();
            this.txtRegFirstname = new System.Windows.Forms.TextBox();
            this.groupBoxKey = new System.Windows.Forms.GroupBox();
            this.buttonEnterKey = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.groupBoxRegRole = new System.Windows.Forms.GroupBox();
            this.radioButtonCompany = new System.Windows.Forms.RadioButton();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelRegistration.SuspendLayout();
            this.groupBoxCompany.SuspendLayout();
            this.groupBoxAccount.SuspendLayout();
            this.groupBoxKey.SuspendLayout();
            this.groupBoxRegRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextboxUsername
            // 
            this.TextboxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextboxUsername.Location = new System.Drawing.Point(61, 131);
            this.TextboxUsername.Name = "TextboxUsername";
            this.TextboxUsername.Size = new System.Drawing.Size(230, 29);
            this.TextboxUsername.TabIndex = 0;
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextboxPassword.Location = new System.Drawing.Point(61, 191);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.PasswordChar = '•';
            this.TextboxPassword.Size = new System.Drawing.Size(230, 29);
            this.TextboxPassword.TabIndex = 1;
            // 
            // BTNLogin
            // 
            this.BTNLogin.BackColor = System.Drawing.Color.White;
            this.BTNLogin.Location = new System.Drawing.Point(121, 257);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(107, 47);
            this.BTNLogin.TabIndex = 2;
            this.BTNLogin.Text = "Login";
            this.BTNLogin.UseVisualStyleBackColor = false;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelLogin.Controls.Add(this.linkLabelR);
            this.panelLogin.Controls.Add(this.labelLogo);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.TextboxUsername);
            this.panelLogin.Controls.Add(this.TextboxPassword);
            this.panelLogin.Controls.Add(this.BTNLogin);
            this.panelLogin.Location = new System.Drawing.Point(97, 90);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(346, 364);
            this.panelLogin.TabIndex = 3;
            // 
            // linkLabelR
            // 
            this.linkLabelR.AutoSize = true;
            this.linkLabelR.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelR.Location = new System.Drawing.Point(221, 223);
            this.linkLabelR.Name = "linkLabelR";
            this.linkLabelR.Size = new System.Drawing.Size(70, 15);
            this.linkLabelR.TabIndex = 6;
            this.linkLabelR.TabStop = true;
            this.linkLabelR.Text = "Registration";
            this.linkLabelR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelR_LinkClicked);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(66, 28);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(225, 71);
            this.labelLogo.TabIndex = 5;
            this.labelLogo.Text = "NoDesk";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(61, 173);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(61, 113);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(41, 15);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "E-mail";
            // 
            // panelRegistration
            // 
            this.panelRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelRegistration.Controls.Add(this.buttonReturnLogin);
            this.panelRegistration.Controls.Add(this.groupBoxCompany);
            this.panelRegistration.Controls.Add(this.groupBoxAccount);
            this.panelRegistration.Controls.Add(this.groupBoxKey);
            this.panelRegistration.Controls.Add(this.groupBoxRegRole);
            this.panelRegistration.Controls.Add(this.label1);
            this.panelRegistration.Location = new System.Drawing.Point(-2, 0);
            this.panelRegistration.Name = "panelRegistration";
            this.panelRegistration.Size = new System.Drawing.Size(537, 572);
            this.panelRegistration.TabIndex = 4;
            // 
            // buttonReturnLogin
            // 
            this.buttonReturnLogin.BackColor = System.Drawing.Color.White;
            this.buttonReturnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonReturnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReturnLogin.Location = new System.Drawing.Point(61, 366);
            this.buttonReturnLogin.Name = "buttonReturnLogin";
            this.buttonReturnLogin.Size = new System.Drawing.Size(127, 37);
            this.buttonReturnLogin.TabIndex = 14;
            this.buttonReturnLogin.Text = "Return to login";
            this.buttonReturnLogin.UseVisualStyleBackColor = false;
            this.buttonReturnLogin.Click += new System.EventHandler(this.buttonReturnLogin_Click);
            // 
            // groupBoxCompany
            // 
            this.groupBoxCompany.Controls.Add(this.textBoxCompany);
            this.groupBoxCompany.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCompany.ForeColor = System.Drawing.Color.White;
            this.groupBoxCompany.Location = new System.Drawing.Point(24, 270);
            this.groupBoxCompany.Name = "groupBoxCompany";
            this.groupBoxCompany.Size = new System.Drawing.Size(200, 71);
            this.groupBoxCompany.TabIndex = 12;
            this.groupBoxCompany.TabStop = false;
            this.groupBoxCompany.Text = "Invited by";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Enabled = false;
            this.textBoxCompany.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCompany.Location = new System.Drawing.Point(18, 27);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.ReadOnly = true;
            this.textBoxCompany.Size = new System.Drawing.Size(160, 27);
            this.textBoxCompany.TabIndex = 4;
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Controls.Add(this.buttonRegister);
            this.groupBoxAccount.Controls.Add(this.label6);
            this.groupBoxAccount.Controls.Add(this.label5);
            this.groupBoxAccount.Controls.Add(this.label4);
            this.groupBoxAccount.Controls.Add(this.label3);
            this.groupBoxAccount.Controls.Add(this.label2);
            this.groupBoxAccount.Controls.Add(this.txtRegPasswordretry);
            this.groupBoxAccount.Controls.Add(this.txtRegPassword);
            this.groupBoxAccount.Controls.Add(this.txtRegEmail);
            this.groupBoxAccount.Controls.Add(this.txtRegLastname);
            this.groupBoxAccount.Controls.Add(this.txtRegFirstname);
            this.groupBoxAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAccount.ForeColor = System.Drawing.Color.White;
            this.groupBoxAccount.Location = new System.Drawing.Point(246, 74);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(265, 365);
            this.groupBoxAccount.TabIndex = 11;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "Account";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.White;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.Location = new System.Drawing.Point(17, 292);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(160, 37);
            this.buttonRegister.TabIndex = 13;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lastname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Firstname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Repeat password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // txtRegPasswordretry
            // 
            this.txtRegPasswordretry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegPasswordretry.Location = new System.Drawing.Point(17, 232);
            this.txtRegPasswordretry.Name = "txtRegPasswordretry";
            this.txtRegPasswordretry.PasswordChar = '•';
            this.txtRegPasswordretry.Size = new System.Drawing.Size(160, 27);
            this.txtRegPasswordretry.TabIndex = 4;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegPassword.Location = new System.Drawing.Point(17, 176);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '•';
            this.txtRegPassword.Size = new System.Drawing.Size(160, 27);
            this.txtRegPassword.TabIndex = 3;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegEmail.Location = new System.Drawing.Point(17, 112);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(190, 27);
            this.txtRegEmail.TabIndex = 2;
            // 
            // txtRegLastname
            // 
            this.txtRegLastname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegLastname.Location = new System.Drawing.Point(141, 53);
            this.txtRegLastname.Name = "txtRegLastname";
            this.txtRegLastname.Size = new System.Drawing.Size(118, 27);
            this.txtRegLastname.TabIndex = 1;
            // 
            // txtRegFirstname
            // 
            this.txtRegFirstname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegFirstname.Location = new System.Drawing.Point(17, 53);
            this.txtRegFirstname.Name = "txtRegFirstname";
            this.txtRegFirstname.Size = new System.Drawing.Size(113, 27);
            this.txtRegFirstname.TabIndex = 0;
            // 
            // groupBoxKey
            // 
            this.groupBoxKey.Controls.Add(this.buttonEnterKey);
            this.groupBoxKey.Controls.Add(this.textBoxKey);
            this.groupBoxKey.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxKey.ForeColor = System.Drawing.Color.White;
            this.groupBoxKey.Location = new System.Drawing.Point(24, 165);
            this.groupBoxKey.Name = "groupBoxKey";
            this.groupBoxKey.Size = new System.Drawing.Size(200, 95);
            this.groupBoxKey.TabIndex = 10;
            this.groupBoxKey.TabStop = false;
            this.groupBoxKey.Text = "Enter invitation key";
            // 
            // buttonEnterKey
            // 
            this.buttonEnterKey.BackColor = System.Drawing.Color.White;
            this.buttonEnterKey.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEnterKey.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnterKey.Location = new System.Drawing.Point(62, 60);
            this.buttonEnterKey.Name = "buttonEnterKey";
            this.buttonEnterKey.Size = new System.Drawing.Size(77, 25);
            this.buttonEnterKey.TabIndex = 12;
            this.buttonEnterKey.Text = "Enter";
            this.buttonEnterKey.UseVisualStyleBackColor = false;
            this.buttonEnterKey.Click += new System.EventHandler(this.buttonEnterKey_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKey.Location = new System.Drawing.Point(7, 21);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(187, 29);
            this.textBoxKey.TabIndex = 11;
            // 
            // groupBoxRegRole
            // 
            this.groupBoxRegRole.Controls.Add(this.radioButtonCompany);
            this.groupBoxRegRole.Controls.Add(this.radioButtonUser);
            this.groupBoxRegRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRegRole.ForeColor = System.Drawing.Color.White;
            this.groupBoxRegRole.Location = new System.Drawing.Point(24, 74);
            this.groupBoxRegRole.Name = "groupBoxRegRole";
            this.groupBoxRegRole.Size = new System.Drawing.Size(104, 85);
            this.groupBoxRegRole.TabIndex = 9;
            this.groupBoxRegRole.TabStop = false;
            this.groupBoxRegRole.Text = "As";
            // 
            // radioButtonCompany
            // 
            this.radioButtonCompany.AutoSize = true;
            this.radioButtonCompany.ForeColor = System.Drawing.Color.White;
            this.radioButtonCompany.Location = new System.Drawing.Point(6, 24);
            this.radioButtonCompany.Name = "radioButtonCompany";
            this.radioButtonCompany.Size = new System.Drawing.Size(81, 21);
            this.radioButtonCompany.TabIndex = 7;
            this.radioButtonCompany.Text = "Company";
            this.radioButtonCompany.UseVisualStyleBackColor = true;
            this.radioButtonCompany.CheckedChanged += new System.EventHandler(this.radioButtonCompany_CheckedChanged);
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Checked = true;
            this.radioButtonUser.ForeColor = System.Drawing.Color.White;
            this.radioButtonUser.Location = new System.Drawing.Point(6, 53);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(53, 21);
            this.radioButtonUser.TabIndex = 8;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "User";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            this.radioButtonUser.CheckedChanged += new System.EventHandler(this.radioButtonUser_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registration";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(534, 571);
            this.Controls.Add(this.panelRegistration);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoDesk | Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegistration.ResumeLayout(false);
            this.panelRegistration.PerformLayout();
            this.groupBoxCompany.ResumeLayout(false);
            this.groupBoxCompany.PerformLayout();
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxAccount.PerformLayout();
            this.groupBoxKey.ResumeLayout(false);
            this.groupBoxKey.PerformLayout();
            this.groupBoxRegRole.ResumeLayout(false);
            this.groupBoxRegRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxUsername;
        private System.Windows.Forms.TextBox TextboxPassword;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.LinkLabel linkLabelR;
        private System.Windows.Forms.Panel panelRegistration;
        private System.Windows.Forms.GroupBox groupBoxRegRole;
        private System.Windows.Forms.RadioButton radioButtonCompany;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonEnterKey;
        private System.Windows.Forms.GroupBox groupBoxCompany;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegPasswordretry;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegLastname;
        private System.Windows.Forms.TextBox txtRegFirstname;
        private System.Windows.Forms.Button buttonReturnLogin;
    }
}