namespace Test_Data_Adder
{
    partial class GenerateReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReportForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNote = new System.Windows.Forms.CheckBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbDefault = new System.Windows.Forms.CheckBox();
            this.cbForward = new System.Windows.Forms.CheckBox();
            this.cbInvoice = new System.Windows.Forms.CheckBox();
            this.cbInventory = new System.Windows.Forms.CheckBox();
            this.cbEmployee = new System.Windows.Forms.CheckBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.pbSending = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNote);
            this.groupBox1.Controls.Add(this.btnEmail);
            this.groupBox1.Controls.Add(this.tbNote);
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.cbDefault);
            this.groupBox1.Controls.Add(this.cbForward);
            this.groupBox1.Location = new System.Drawing.Point(331, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 435);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Report";
            // 
            // cbNote
            // 
            this.cbNote.AutoSize = true;
            this.cbNote.Location = new System.Drawing.Point(30, 199);
            this.cbNote.Name = "cbNote";
            this.cbNote.Size = new System.Drawing.Size(172, 24);
            this.cbNote.TabIndex = 27;
            this.cbNote.Text = "Add Note (optional)";
            this.cbNote.UseVisualStyleBackColor = true;
            this.cbNote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CbNote_MouseClick);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(219, 371);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(257, 41);
            this.btnEmail.TabIndex = 15;
            this.btnEmail.Text = "Send Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.BtnEmail_Click);
            // 
            // tbNote
            // 
            this.tbNote.Enabled = false;
            this.tbNote.Location = new System.Drawing.Point(30, 229);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNote.Size = new System.Drawing.Size(443, 126);
            this.tbNote.TabIndex = 26;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Enabled = false;
            this.lblNote.Location = new System.Drawing.Point(259, 153);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(214, 20);
            this.lblNote.TabIndex = 22;
            this.lblNote.Text = "*separate emails with spaces";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(30, 119);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(443, 26);
            this.tbEmail.TabIndex = 1;
            // 
            // cbDefault
            // 
            this.cbDefault.AutoSize = true;
            this.cbDefault.Location = new System.Drawing.Point(30, 49);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(257, 24);
            this.cbDefault.TabIndex = 20;
            this.cbDefault.Text = "Default (greffnoah@gmail.com)";
            this.cbDefault.UseVisualStyleBackColor = true;
            this.cbDefault.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CbDefault_MouseClick);
            // 
            // cbForward
            // 
            this.cbForward.AutoSize = true;
            this.cbForward.Location = new System.Drawing.Point(30, 89);
            this.cbForward.Name = "cbForward";
            this.cbForward.Size = new System.Drawing.Size(119, 24);
            this.cbForward.TabIndex = 21;
            this.cbForward.Text = "Forward To:";
            this.cbForward.UseVisualStyleBackColor = true;
            this.cbForward.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CbForward_MouseClick);
            // 
            // cbInvoice
            // 
            this.cbInvoice.AutoSize = true;
            this.cbInvoice.Location = new System.Drawing.Point(37, 345);
            this.cbInvoice.Name = "cbInvoice";
            this.cbInvoice.Size = new System.Drawing.Size(138, 24);
            this.cbInvoice.TabIndex = 19;
            this.cbInvoice.Text = "Invoice Report";
            this.cbInvoice.UseVisualStyleBackColor = true;
            // 
            // cbInventory
            // 
            this.cbInventory.AutoSize = true;
            this.cbInventory.Location = new System.Drawing.Point(37, 380);
            this.cbInventory.Name = "cbInventory";
            this.cbInventory.Size = new System.Drawing.Size(153, 24);
            this.cbInventory.TabIndex = 20;
            this.cbInventory.Text = "Inventory Report";
            this.cbInventory.UseVisualStyleBackColor = true;
            // 
            // cbEmployee
            // 
            this.cbEmployee.AutoSize = true;
            this.cbEmployee.Location = new System.Drawing.Point(37, 415);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(158, 24);
            this.cbEmployee.TabIndex = 21;
            this.cbEmployee.Text = "Employee Report";
            this.cbEmployee.UseVisualStyleBackColor = true;
            // 
            // pbIcon
            // 
            this.pbIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbIcon.InitialImage")));
            this.pbIcon.Location = new System.Drawing.Point(73, 66);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(180, 180);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 22;
            this.pbIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 257);
            this.label1.TabIndex = 24;
            // 
            // cbAddress
            // 
            this.cbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(36, 299);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(257, 28);
            this.cbAddress.TabIndex = 26;
            // 
            // pbSending
            // 
            this.pbSending.Location = new System.Drawing.Point(-2, -15);
            this.pbSending.Name = "pbSending";
            this.pbSending.Size = new System.Drawing.Size(867, 23);
            this.pbSending.TabIndex = 27;
            // 
            // GenerateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 483);
            this.Controls.Add(this.pbSending);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.cbInvoice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbInventory);
            this.Controls.Add(this.cbAddress);
            this.Name = "GenerateReportForm";
            this.Text = "Generate Report";
            this.Load += new System.EventHandler(this.GenerateReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.CheckBox cbForward;
        private System.Windows.Forms.CheckBox cbDefault;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.CheckBox cbInvoice;
        private System.Windows.Forms.CheckBox cbInventory;
        private System.Windows.Forms.CheckBox cbEmployee;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.CheckBox cbNote;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.ProgressBar pbSending;
    }
}