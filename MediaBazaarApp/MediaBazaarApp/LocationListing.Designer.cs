namespace MediaBazaarApp
{
    partial class LocationListing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStoreTitle = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStoreTitle
            // 
            this.lblStoreTitle.AutoSize = true;
            this.lblStoreTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreTitle.Location = new System.Drawing.Point(19, 24);
            this.lblStoreTitle.Name = "lblStoreTitle";
            this.lblStoreTitle.Size = new System.Drawing.Size(101, 23);
            this.lblStoreTitle.TabIndex = 0;
            this.lblStoreTitle.Text = "Store Title";
            this.lblStoreTitle.Click += new System.EventHandler(this.AllControls_Click);
            this.lblStoreTitle.MouseEnter += new System.EventHandler(this.MouseEnter_Field);
            this.lblStoreTitle.MouseLeave += new System.EventHandler(this.MouseLeave_Field);
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(89, 64);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(333, 21);
            this.lblAddress.TabIndex = 46;
            this.lblAddress.Text = "Rachelsmolen 1, 5612 MA Eindhoven";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAddress.Click += new System.EventHandler(this.AllControls_Click);
            this.lblAddress.MouseEnter += new System.EventHandler(this.MouseEnter_Field);
            this.lblAddress.MouseLeave += new System.EventHandler(this.MouseLeave_Field);
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(89, 100);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(333, 21);
            this.lblTel.TabIndex = 47;
            this.lblTel.Text = "+123456789";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTel.Click += new System.EventHandler(this.AllControls_Click);
            this.lblTel.MouseEnter += new System.EventHandler(this.MouseEnter_Field);
            this.lblTel.MouseLeave += new System.EventHandler(this.MouseLeave_Field);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(89, 134);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(333, 21);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "example@email.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmail.Click += new System.EventHandler(this.AllControls_Click);
            this.lblEmail.MouseEnter += new System.EventHandler(this.MouseEnter_Field);
            this.lblEmail.MouseLeave += new System.EventHandler(this.MouseLeave_Field);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.AllControls_Click);
            this.label3.MouseEnter += new System.EventHandler(this.MouseEnter_Field);
            this.label3.MouseLeave += new System.EventHandler(this.MouseLeave_Field);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(19, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tel:";
            this.label4.Click += new System.EventHandler(this.AllControls_Click);
            this.label4.MouseEnter += new System.EventHandler(this.MouseEnter_Field);
            this.label4.MouseLeave += new System.EventHandler(this.MouseLeave_Field);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label5.Location = new System.Drawing.Point(19, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Add.";
            this.label5.Click += new System.EventHandler(this.AllControls_Click);
            this.label5.MouseEnter += new System.EventHandler(this.MouseEnter_Field);
            this.label5.MouseLeave += new System.EventHandler(this.MouseLeave_Field);
            // 
            // LocationListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStoreTitle);
            this.Name = "LocationListing";
            this.Size = new System.Drawing.Size(440, 173);
            this.Click += new System.EventHandler(this.AllControls_Click);
            this.MouseEnter += new System.EventHandler(this.MouseEnter_Field);
            this.MouseLeave += new System.EventHandler(this.MouseLeave_Field);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStoreTitle;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
