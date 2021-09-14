
namespace NoDeskUI
{
    partial class NoDesk
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.UMBTN = new System.Windows.Forms.Button();
            this.IMBTN = new System.Windows.Forms.Button();
            this.DashboardBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.formsPlotDayPie = new ScottPlot.FormsPlot();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chartWeek = new ScottPlot.FormsPlot();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.MenuPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1036, 133);
            this.TopPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(875, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 47);
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
            this.MenuPanel.Location = new System.Drawing.Point(0, 82);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1036, 51);
            this.MenuPanel.TabIndex = 0;
            // 
            // UMBTN
            // 
            this.UMBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.UMBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.UMBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UMBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UMBTN.ForeColor = System.Drawing.Color.White;
            this.UMBTN.Location = new System.Drawing.Point(341, 0);
            this.UMBTN.Name = "UMBTN";
            this.UMBTN.Size = new System.Drawing.Size(199, 51);
            this.UMBTN.TabIndex = 2;
            this.UMBTN.Text = "User Management";
            this.UMBTN.UseVisualStyleBackColor = false;
            // 
            // IMBTN
            // 
            this.IMBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.IMBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.IMBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IMBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IMBTN.ForeColor = System.Drawing.Color.White;
            this.IMBTN.Location = new System.Drawing.Point(142, 0);
            this.IMBTN.Name = "IMBTN";
            this.IMBTN.Size = new System.Drawing.Size(199, 51);
            this.IMBTN.TabIndex = 1;
            this.IMBTN.Text = "Incident Management";
            this.IMBTN.UseVisualStyleBackColor = false;
            // 
            // DashboardBTN
            // 
            this.DashboardBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.DashboardBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.DashboardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardBTN.ForeColor = System.Drawing.Color.White;
            this.DashboardBTN.Location = new System.Drawing.Point(0, 0);
            this.DashboardBTN.Name = "DashboardBTN";
            this.DashboardBTN.Size = new System.Drawing.Size(142, 51);
            this.DashboardBTN.TabIndex = 0;
            this.DashboardBTN.Text = "Dashboard";
            this.DashboardBTN.UseVisualStyleBackColor = false;
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
            // formsPlotDayPie
            // 
            this.formsPlotDayPie.BackColor = System.Drawing.Color.Transparent;
            this.formsPlotDayPie.Location = new System.Drawing.Point(37, 225);
            this.formsPlotDayPie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotDayPie.Name = "formsPlotDayPie";
            this.formsPlotDayPie.Size = new System.Drawing.Size(295, 342);
            this.formsPlotDayPie.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(59, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Today\'s incident overview";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(117, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "All current tickets";
            // 
            // chartWeek
            // 
            this.chartWeek.BackColor = System.Drawing.Color.Transparent;
            this.chartWeek.Location = new System.Drawing.Point(383, 225);
            this.chartWeek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartWeek.Name = "chartWeek";
            this.chartWeek.Size = new System.Drawing.Size(619, 346);
            this.chartWeek.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(571, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Weekly incident overview";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(601, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "All tickets through the week";
            // 
            // NoDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1036, 628);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartWeek);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formsPlotDayPie);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TopPanel);
            this.Name = "NoDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoDesk | Dashboard";
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
        private ScottPlot.FormsPlot formsPlotDayPie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private ScottPlot.FormsPlot chartWeek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

