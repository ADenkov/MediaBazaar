namespace OrdersApp
{
    partial class ProductOrderListing
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
            this.lblSKU = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cbCount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSKU.ForeColor = System.Drawing.Color.Black;
            this.lblSKU.Location = new System.Drawing.Point(83, 32);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(81, 17);
            this.lblSKU.TabIndex = 49;
            this.lblSKU.Text = "PRODUCT_ID";
            this.lblSKU.Click += new System.EventHandler(this.AllControls_Click);
            this.lblSKU.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblSKU.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(82, 10);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 15);
            this.lblName.TabIndex = 48;
            this.lblName.Text = "Product Name";
            this.lblName.Click += new System.EventHandler(this.AllControls_Click);
            this.lblName.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblName.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(331, 32);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(44, 15);
            this.lblQuantity.TabIndex = 50;
            this.lblQuantity.Text = "12";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuantity.Visible = false;
            this.lblQuantity.Click += new System.EventHandler(this.AllControls_Click);
            this.lblQuantity.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblQuantity.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(7, 6);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(67, 65);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 51;
            this.pbIcon.TabStop = false;
            this.pbIcon.Click += new System.EventHandler(this.AllControls_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBrand.ForeColor = System.Drawing.Color.Black;
            this.lblBrand.Location = new System.Drawing.Point(83, 52);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(42, 17);
            this.lblBrand.TabIndex = 52;
            this.lblBrand.Text = "Brand";
            this.lblBrand.Click += new System.EventHandler(this.AllControls_Click);
            this.lblBrand.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblBrand.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // cbCount
            // 
            this.cbCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCount.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCount.FormattingEnabled = true;
            this.cbCount.Location = new System.Drawing.Point(341, 30);
            this.cbCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCount.Name = "cbCount";
            this.cbCount.Size = new System.Drawing.Size(55, 24);
            this.cbCount.TabIndex = 53;
            this.cbCount.Visible = false;
            this.cbCount.SelectionChangeCommitted += new System.EventHandler(this.CbCount_SelectionChangeCommitted);
            // 
            // ProductOrderListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbCount);
            this.Controls.Add(this.lblQuantity);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductOrderListing";
            this.Size = new System.Drawing.Size(415, 78);
            this.Click += new System.EventHandler(this.AllControls_Click);
            this.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cbCount;
    }
}
