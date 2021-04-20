namespace MediaBazaarApp
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.pMain = new System.Windows.Forms.Panel();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbWeek = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpSunday = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFriday = new System.Windows.Forms.FlowLayoutPanel();
            this.flpThursday = new System.Windows.Forms.FlowLayoutPanel();
            this.flpWednesday = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTuseday = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMonday = new System.Windows.Forms.FlowLayoutPanel();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.label2);
            this.pMain.Controls.Add(this.panel4);
            this.pMain.Controls.Add(this.label1);
            this.pMain.Controls.Add(this.panel3);
            this.pMain.Controls.Add(this.label19);
            this.pMain.Controls.Add(this.panel2);
            this.pMain.Controls.Add(this.flpSunday);
            this.pMain.Controls.Add(this.flpFriday);
            this.pMain.Controls.Add(this.flpThursday);
            this.pMain.Controls.Add(this.flpWednesday);
            this.pMain.Controls.Add(this.flpTuseday);
            this.pMain.Controls.Add(this.flpMonday);
            this.pMain.Controls.Add(this.cbDepartment);
            this.pMain.Controls.Add(this.cbWeek);
            this.pMain.Controls.Add(this.label4);
            this.pMain.Controls.Add(this.label8);
            this.pMain.Controls.Add(this.label9);
            this.pMain.Controls.Add(this.label11);
            this.pMain.Controls.Add(this.lblDepartment);
            this.pMain.Controls.Add(this.label12);
            this.pMain.Controls.Add(this.cbLocation);
            this.pMain.Controls.Add(this.label13);
            this.pMain.Controls.Add(this.lblLocation);
            this.pMain.Controls.Add(this.label14);
            this.pMain.Controls.Add(this.label10);
            this.pMain.Controls.Add(this.pictureBox2);
            this.pMain.Location = new System.Drawing.Point(15, 17);
            this.pMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1614, 963);
            this.pMain.TabIndex = 32;
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbDepartment.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Floor Employee",
            "Warehouse Worker"});
            this.cbDepartment.Location = new System.Drawing.Point(765, 83);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(394, 29);
            this.cbDepartment.TabIndex = 122;
            this.cbDepartment.SelectionChangeCommitted += new System.EventHandler(this.Controls_ChangeCommited);
            // 
            // cbWeek
            // 
            this.cbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeek.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbWeek.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWeek.FormattingEnabled = true;
            this.cbWeek.Location = new System.Drawing.Point(1362, 35);
            this.cbWeek.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbWeek.Name = "cbWeek";
            this.cbWeek.Size = new System.Drawing.Size(186, 29);
            this.cbWeek.TabIndex = 81;
            this.cbWeek.SelectionChangeCommitted += new System.EventHandler(this.Controls_ChangeCommited);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1263, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 80;
            this.label4.Text = "Week:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label8.Location = new System.Drawing.Point(1278, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 23);
            this.label8.TabIndex = 78;
            this.label8.Text = "Sunday";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label9.Location = new System.Drawing.Point(1042, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 23);
            this.label9.TabIndex = 77;
            this.label9.Text = "Friday";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label11.Location = new System.Drawing.Point(806, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 23);
            this.label11.TabIndex = 76;
            this.label11.Text = "Thursday";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepartment.Location = new System.Drawing.Point(611, 85);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(120, 22);
            this.lblDepartment.TabIndex = 63;
            this.lblDepartment.Text = "Department:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label12.Location = new System.Drawing.Point(570, 139);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(234, 23);
            this.label12.TabIndex = 75;
            this.label12.Text = "Wednesday";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLocation.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(160, 83);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(394, 29);
            this.cbLocation.TabIndex = 62;
            this.cbLocation.SelectionChangeCommitted += new System.EventHandler(this.Controls_ChangeCommited);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label13.Location = new System.Drawing.Point(334, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(234, 23);
            this.label13.TabIndex = 74;
            this.label13.Text = "Tuesday";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLocation.Location = new System.Drawing.Point(35, 85);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(91, 22);
            this.lblLocation.TabIndex = 61;
            this.lblLocation.Text = "Location:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label14.Location = new System.Drawing.Point(98, 139);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 23);
            this.label14.TabIndex = 56;
            this.label14.Text = "Monday";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label10.Location = new System.Drawing.Point(113, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 36);
            this.label10.TabIndex = 5;
            this.label10.Text = "Dashboard";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label2.Location = new System.Drawing.Point(35, 720);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 134;
            this.label2.Text = "17:00";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.panel4.Location = new System.Drawing.Point(39, 713);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1473, 2);
            this.panel4.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(35, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 132;
            this.label1.Text = "12:00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.panel3.Location = new System.Drawing.Point(39, 449);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1473, 2);
            this.panel3.TabIndex = 131;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label19.Location = new System.Drawing.Point(35, 192);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 23);
            this.label19.TabIndex = 124;
            this.label19.Text = "08:00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.panel2.Location = new System.Drawing.Point(39, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1473, 2);
            this.panel2.TabIndex = 123;
            // 
            // flpSunday
            // 
            this.flpSunday.BackColor = System.Drawing.Color.White;
            this.flpSunday.Location = new System.Drawing.Point(1282, 184);
            this.flpSunday.Name = "flpSunday";
            this.flpSunday.Size = new System.Drawing.Size(230, 801);
            this.flpSunday.TabIndex = 130;
            // 
            // flpFriday
            // 
            this.flpFriday.BackColor = System.Drawing.Color.White;
            this.flpFriday.Location = new System.Drawing.Point(1046, 184);
            this.flpFriday.Name = "flpFriday";
            this.flpFriday.Size = new System.Drawing.Size(230, 801);
            this.flpFriday.TabIndex = 129;
            // 
            // flpThursday
            // 
            this.flpThursday.BackColor = System.Drawing.Color.White;
            this.flpThursday.Location = new System.Drawing.Point(810, 184);
            this.flpThursday.Name = "flpThursday";
            this.flpThursday.Size = new System.Drawing.Size(230, 801);
            this.flpThursday.TabIndex = 128;
            // 
            // flpWednesday
            // 
            this.flpWednesday.BackColor = System.Drawing.Color.White;
            this.flpWednesday.Location = new System.Drawing.Point(574, 184);
            this.flpWednesday.Name = "flpWednesday";
            this.flpWednesday.Size = new System.Drawing.Size(230, 801);
            this.flpWednesday.TabIndex = 127;
            // 
            // flpTuseday
            // 
            this.flpTuseday.BackColor = System.Drawing.Color.White;
            this.flpTuseday.Location = new System.Drawing.Point(338, 184);
            this.flpTuseday.Name = "flpTuseday";
            this.flpTuseday.Size = new System.Drawing.Size(230, 801);
            this.flpTuseday.TabIndex = 126;
            // 
            // flpMonday
            // 
            this.flpMonday.BackColor = System.Drawing.Color.White;
            this.flpMonday.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMonday.Location = new System.Drawing.Point(102, 184);
            this.flpMonday.Name = "flpMonday";
            this.flpMonday.Size = new System.Drawing.Size(230, 801);
            this.flpMonday.TabIndex = 125;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1647, 977);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbWeek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpSunday;
        private System.Windows.Forms.FlowLayoutPanel flpFriday;
        private System.Windows.Forms.FlowLayoutPanel flpThursday;
        private System.Windows.Forms.FlowLayoutPanel flpWednesday;
        private System.Windows.Forms.FlowLayoutPanel flpTuseday;
        private System.Windows.Forms.FlowLayoutPanel flpMonday;
    }
}