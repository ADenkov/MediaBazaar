namespace MediaBazaarApp
{
    partial class AnnoucementsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnoucementsForm));
            this.pCompanyInfo = new System.Windows.Forms.Panel();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.flpAnnoucement = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pCompanyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pCompanyInfo
            // 
            this.pCompanyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCompanyInfo.BackColor = System.Drawing.Color.White;
            this.pCompanyInfo.Controls.Add(this.cbLocation);
            this.pCompanyInfo.Controls.Add(this.label3);
            this.pCompanyInfo.Controls.Add(this.cbDepartment);
            this.pCompanyInfo.Controls.Add(this.label58);
            this.pCompanyInfo.Controls.Add(this.flpAnnoucement);
            this.pCompanyInfo.Controls.Add(this.label1);
            this.pCompanyInfo.Controls.Add(this.pictureBox1);
            this.pCompanyInfo.Location = new System.Drawing.Point(14, 14);
            this.pCompanyInfo.Name = "pCompanyInfo";
            this.pCompanyInfo.Size = new System.Drawing.Size(1069, 621);
            this.pCompanyInfo.TabIndex = 9;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLocation.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "All"});
            this.cbLocation.Location = new System.Drawing.Point(828, 84);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(208, 24);
            this.cbLocation.TabIndex = 81;
            this.cbLocation.SelectionChangeCommitted += new System.EventHandler(this.AllComboBox_SelectionCommited);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(825, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "From Department:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbDepartment.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "All",
            "Adminsitrator",
            "Manager",
            "Floor Employee",
            "Warehouse Worker"});
            this.cbDepartment.Location = new System.Drawing.Point(828, 140);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(208, 24);
            this.cbDepartment.TabIndex = 79;
            this.cbDepartment.SelectionChangeCommitted += new System.EventHandler(this.AllComboBox_SelectionCommited);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label58.Location = new System.Drawing.Point(825, 61);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(93, 16);
            this.label58.TabIndex = 75;
            this.label58.Text = "From Location:";
            // 
            // flpAnnoucement
            // 
            this.flpAnnoucement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpAnnoucement.AutoScroll = true;
            this.flpAnnoucement.Location = new System.Drawing.Point(65, 61);
            this.flpAnnoucement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpAnnoucement.Name = "flpAnnoucement";
            this.flpAnnoucement.Size = new System.Drawing.Size(729, 560);
            this.flpAnnoucement.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Annoucements";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AnnoucementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.pCompanyInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AnnoucementsForm";
            this.Text = "AnnoucementsForm";
            this.Load += new System.EventHandler(this.AnnoucementsForm_Load);
            this.pCompanyInfo.ResumeLayout(false);
            this.pCompanyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCompanyInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpAnnoucement;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label58;
    }
}