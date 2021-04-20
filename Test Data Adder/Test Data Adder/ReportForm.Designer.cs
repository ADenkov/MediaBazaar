namespace Test_Data_Adder
{
    partial class ReportForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.cbForward = new System.Windows.Forms.CheckBox();
            this.cbDefault = new System.Windows.Forms.CheckBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCAddress = new System.Windows.Forms.TextBox();
            this.tbCTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCWebsite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPIC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEmail);
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.cbForward);
            this.groupBox1.Controls.Add(this.cbDefault);
            this.groupBox1.Controls.Add(this.buttonEmail);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Location = new System.Drawing.Point(349, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 366);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Report";
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(29, 97);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(137, 24);
            this.cbEmail.TabIndex = 23;
            this.cbEmail.Text = "Send via email";
            this.cbEmail.UseVisualStyleBackColor = true;
            this.cbEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CbEmail_MouseClick);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(67, 242);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(214, 20);
            this.lblNote.TabIndex = 22;
            this.lblNote.Text = "*separate emails with spaces";
            // 
            // cbForward
            // 
            this.cbForward.AutoSize = true;
            this.cbForward.Location = new System.Drawing.Point(29, 178);
            this.cbForward.Name = "cbForward";
            this.cbForward.Size = new System.Drawing.Size(119, 24);
            this.cbForward.TabIndex = 21;
            this.cbForward.Text = "Forward To:";
            this.cbForward.UseVisualStyleBackColor = true;
            this.cbForward.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CbForward_MouseClick);
            // 
            // cbDefault
            // 
            this.cbDefault.AutoSize = true;
            this.cbDefault.Location = new System.Drawing.Point(29, 146);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(257, 24);
            this.cbDefault.TabIndex = 20;
            this.cbDefault.Text = "Default (greffnoah@gmail.com)";
            this.cbDefault.UseVisualStyleBackColor = true;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(153, 1221);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(267, 41);
            this.buttonDownload.TabIndex = 18;
            this.buttonDownload.Text = "Load PDF";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(29, 287);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(257, 41);
            this.buttonEmail.TabIndex = 15;
            this.buttonEmail.Text = "Send Email";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.ButtonEmail_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(29, 208);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(252, 26);
            this.textBoxEmail.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 366);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Report";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(29, 97);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(223, 24);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Include Inventory Overview";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(29, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(139, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Include Orders";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Until:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(88, 174);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(198, 26);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(373, 844);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(257, 41);
            this.buttonGenerate.TabIndex = 21;
            this.buttonGenerate.Text = "Generate Report";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Address:";
            // 
            // tbCAddress
            // 
            this.tbCAddress.Location = new System.Drawing.Point(115, 451);
            this.tbCAddress.Name = "tbCAddress";
            this.tbCAddress.Size = new System.Drawing.Size(515, 26);
            this.tbCAddress.TabIndex = 25;
            // 
            // tbCTel
            // 
            this.tbCTel.Location = new System.Drawing.Point(115, 488);
            this.tbCTel.Name = "tbCTel";
            this.tbCTel.Size = new System.Drawing.Size(515, 26);
            this.tbCTel.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Phone:";
            // 
            // tbCEmail
            // 
            this.tbCEmail.Location = new System.Drawing.Point(115, 525);
            this.tbCEmail.Name = "tbCEmail";
            this.tbCEmail.Size = new System.Drawing.Size(515, 26);
            this.tbCEmail.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Email:";
            // 
            // tbCWebsite
            // 
            this.tbCWebsite.Location = new System.Drawing.Point(115, 562);
            this.tbCWebsite.Name = "tbCWebsite";
            this.tbCWebsite.Size = new System.Drawing.Size(515, 26);
            this.tbCWebsite.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Website:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Company Credentials:";
            // 
            // tbPIC
            // 
            this.tbPIC.Location = new System.Drawing.Point(115, 612);
            this.tbPIC.Name = "tbPIC";
            this.tbPIC.Size = new System.Drawing.Size(198, 26);
            this.tbPIC.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 615);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "PIC:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(115, 649);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(198, 26);
            this.tbAddress.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 652);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Address:";
            // 
            // tbAP
            // 
            this.tbAP.Location = new System.Drawing.Point(115, 686);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(198, 26);
            this.tbAP.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 689);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "AP by:";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(115, 723);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(515, 95);
            this.tbNote.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 726);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Note:";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(153, 1163);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(267, 41);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Upload Document";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(718, 27);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1674, 1480);
            this.dgv.TabIndex = 43;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2478, 1519);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbAP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPIC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCWebsite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCAddress;
        private System.Windows.Forms.TextBox tbCTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCWebsite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPIC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbForward;
        private System.Windows.Forms.CheckBox cbDefault;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridView dgv;
    }
}