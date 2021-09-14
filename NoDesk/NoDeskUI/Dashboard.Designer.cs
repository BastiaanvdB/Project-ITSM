
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formsPlotUnresolved = new ScottPlot.FormsPlot();
            this.formsPlotPastDeadline = new ScottPlot.FormsPlot();
            this.formsPlotResolved = new ScottPlot.FormsPlot();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.UMBTN.Text = "Incident Management";
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
            this.pictureBox2.Image = global::NoDeskUI.Properties.Resources.panel_R;
            this.pictureBox2.Location = new System.Drawing.Point(371, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(295, 449);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoDeskUI.Properties.Resources.panel_R;
            this.pictureBox1.Location = new System.Drawing.Point(706, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // formsPlotUnresolved
            // 
            this.formsPlotUnresolved.BackColor = System.Drawing.Color.Transparent;
            this.formsPlotUnresolved.Location = new System.Drawing.Point(37, 179);
            this.formsPlotUnresolved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotUnresolved.Name = "formsPlotUnresolved";
            this.formsPlotUnresolved.Size = new System.Drawing.Size(295, 388);
            this.formsPlotUnresolved.TabIndex = 5;
            // 
            // formsPlotPastDeadline
            // 
            this.formsPlotPastDeadline.BackColor = System.Drawing.Color.Transparent;
            this.formsPlotPastDeadline.Location = new System.Drawing.Point(371, 179);
            this.formsPlotPastDeadline.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotPastDeadline.Name = "formsPlotPastDeadline";
            this.formsPlotPastDeadline.Size = new System.Drawing.Size(295, 388);
            this.formsPlotPastDeadline.TabIndex = 6;
            // 
            // formsPlotResolved
            // 
            this.formsPlotResolved.BackColor = System.Drawing.Color.Transparent;
            this.formsPlotResolved.Location = new System.Drawing.Point(706, 179);
            this.formsPlotResolved.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotResolved.Name = "formsPlotResolved";
            this.formsPlotResolved.Size = new System.Drawing.Size(295, 388);
            this.formsPlotResolved.TabIndex = 7;
            // 
            // NoDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1036, 628);
            this.Controls.Add(this.formsPlotResolved);
            this.Controls.Add(this.formsPlotPastDeadline);
            this.Controls.Add(this.formsPlotUnresolved);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private ScottPlot.FormsPlot formsPlotUnresolved;
        private ScottPlot.FormsPlot formsPlotPastDeadline;
        private ScottPlot.FormsPlot formsPlotResolved;
    }
}

