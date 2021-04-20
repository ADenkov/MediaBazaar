namespace MediaBazaarApp
{
    partial class SpecificProductLisitng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecificProductLisitng));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRestock = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbSale = new System.Windows.Forms.PictureBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "EUR";
            this.label1.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.label1.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(533, 42);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 23);
            this.lblPrice.TabIndex = 59;
            this.lblPrice.Text = "213.34";
            this.lblPrice.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblPrice.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblRestock
            // 
            this.lblRestock.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestock.Location = new System.Drawing.Point(754, 52);
            this.lblRestock.Name = "lblRestock";
            this.lblRestock.Size = new System.Drawing.Size(155, 23);
            this.lblRestock.TabIndex = 58;
            this.lblRestock.Text = "DateTime";
            this.lblRestock.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblRestock.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(344, 52);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(105, 23);
            this.lblCondition.TabIndex = 56;
            this.lblCondition.Text = "Condition";
            this.lblCondition.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblCondition.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblSerial
            // 
            this.lblSerial.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(139, 52);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(171, 23);
            this.lblSerial.TabIndex = 54;
            this.lblSerial.Text = "Product Name";
            this.lblSerial.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblSerial.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(15, 15);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(15);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(90, 90);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 53;
            this.pbIcon.TabStop = false;
            this.pbIcon.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.pbIcon.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // pbSale
            // 
            this.pbSale.Image = ((System.Drawing.Image)(resources.GetObject("pbSale.Image")));
            this.pbSale.Location = new System.Drawing.Point(915, 60);
            this.pbSale.Margin = new System.Windows.Forms.Padding(0);
            this.pbSale.Name = "pbSale";
            this.pbSale.Size = new System.Drawing.Size(60, 60);
            this.pbSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSale.TabIndex = 61;
            this.pbSale.TabStop = false;
            this.pbSale.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Gray;
            this.lblDiscount.Location = new System.Drawing.Point(882, 75);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(55, 23);
            this.lblDiscount.TabIndex = 62;
            this.lblDiscount.Text = "20%";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiscount.Visible = false;
            // 
            // SpecificProductLisitng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.pbSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRestock);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.pbIcon);
            this.Name = "SpecificProductLisitng";
            this.Size = new System.Drawing.Size(975, 120);
            this.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRestock;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.PictureBox pbSale;
        private System.Windows.Forms.Label lblDiscount;
    }
}
