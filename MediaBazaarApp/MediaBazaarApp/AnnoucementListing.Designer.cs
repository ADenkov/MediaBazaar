namespace MediaBazaarApp
{
    partial class AnnoucementListing
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
            this.btnMarkRead = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblSentByDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMarkRead
            // 
            this.btnMarkRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkRead.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkRead.Location = new System.Drawing.Point(876, 325);
            this.btnMarkRead.Name = "btnMarkRead";
            this.btnMarkRead.Size = new System.Drawing.Size(150, 49);
            this.btnMarkRead.TabIndex = 21;
            this.btnMarkRead.Text = "Mark as seen";
            this.btnMarkRead.UseVisualStyleBackColor = true;
            this.btnMarkRead.Click += new System.EventHandler(this.BtnMarkRead_Click);
            this.btnMarkRead.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.btnMarkRead.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(34, 29);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(176, 28);
            this.lblSubject.TabIndex = 22;
            this.lblSubject.Text = "Annoucement";
            this.lblSubject.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblSubject.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblContent
            // 
            this.lblContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContent.ForeColor = System.Drawing.Color.Black;
            this.lblContent.Location = new System.Drawing.Point(34, 77);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(992, 232);
            this.lblContent.TabIndex = 47;
            this.lblContent.Text = "Rachelsmolen 1, 5612 MA Eindhoven";
            this.lblContent.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblContent.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblSentByDate
            // 
            this.lblSentByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSentByDate.AutoSize = true;
            this.lblSentByDate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSentByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblSentByDate.Location = new System.Drawing.Point(34, 325);
            this.lblSentByDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSentByDate.Name = "lblSentByDate";
            this.lblSentByDate.Size = new System.Drawing.Size(255, 21);
            this.lblSentByDate.TabIndex = 50;
            this.lblSentByDate.Text = "Sent by <Employee> on <date>";
            this.lblSentByDate.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblSentByDate.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblLocation.Location = new System.Drawing.Point(34, 353);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(82, 21);
            this.lblLocation.TabIndex = 51;
            this.lblLocation.Text = "Location:";
            // 
            // AnnoucementListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSentByDate);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnMarkRead);
            this.Name = "AnnoucementListing";
            this.Size = new System.Drawing.Size(1060, 400);
            this.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarkRead;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblSentByDate;
        private System.Windows.Forms.Label lblLocation;
    }
}
