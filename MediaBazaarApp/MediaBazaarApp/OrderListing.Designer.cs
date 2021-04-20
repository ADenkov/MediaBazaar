namespace MediaBazaarApp
{
    partial class OrderListing
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblOrdered = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Delivery:";
            this.label4.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.label4.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label5.Location = new System.Drawing.Point(21, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Ordered:";
            this.label5.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.label5.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblDelivery
            // 
            this.lblDelivery.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDelivery.ForeColor = System.Drawing.Color.Black;
            this.lblDelivery.Location = new System.Drawing.Point(140, 105);
            this.lblDelivery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(247, 21);
            this.lblDelivery.TabIndex = 54;
            this.lblDelivery.Text = "DateTime";
            this.lblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDelivery.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblDelivery.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblOrdered
            // 
            this.lblOrdered.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrdered.ForeColor = System.Drawing.Color.Black;
            this.lblOrdered.Location = new System.Drawing.Point(140, 69);
            this.lblOrdered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdered.Name = "lblOrdered";
            this.lblOrdered.Size = new System.Drawing.Size(247, 21);
            this.lblOrdered.TabIndex = 53;
            this.lblOrdered.Text = "DateTime";
            this.lblOrdered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOrdered.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblOrdered.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(21, 26);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(127, 23);
            this.lblOrderID.TabIndex = 52;
            this.lblOrderID.Text = "IN-12345678";
            this.lblOrderID.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblOrderID.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // OrderListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblOrdered);
            this.Controls.Add(this.lblOrderID);
            this.Name = "OrderListing";
            this.Size = new System.Drawing.Size(405, 150);
            this.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblOrdered;
        private System.Windows.Forms.Label lblOrderID;
    }
}
