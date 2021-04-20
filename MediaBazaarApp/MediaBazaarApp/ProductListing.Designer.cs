namespace MediaBazaarApp
{
    partial class ProductListing
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
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(15, 15);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(15);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(120, 120);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            this.pbIcon.Click += new System.EventHandler(this.AllControls_Click);
            this.pbIcon.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.pbIcon.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(154, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(190, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Product Name";
            this.lblName.Click += new System.EventHandler(this.AllControls_Click);
            this.lblName.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblName.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSKU.ForeColor = System.Drawing.Color.Black;
            this.lblSKU.Location = new System.Drawing.Point(154, 81);
            this.lblSKU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(123, 21);
            this.lblSKU.TabIndex = 47;
            this.lblSKU.Text = "PRODUCT_ID";
            this.lblSKU.Click += new System.EventHandler(this.AllControls_Click);
            this.lblSKU.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblSKU.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(371, 63);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(86, 23);
            this.lblDepartment.TabIndex = 48;
            this.lblDepartment.Text = "Laptops";
            this.lblDepartment.Click += new System.EventHandler(this.AllControls_Click);
            this.lblDepartment.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblDepartment.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(535, 63);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(69, 23);
            this.lblBrand.TabIndex = 49;
            this.lblBrand.Text = "Apple";
            this.lblBrand.Click += new System.EventHandler(this.AllControls_Click);
            this.lblBrand.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblBrand.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(741, 63);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(32, 23);
            this.lblQuantity.TabIndex = 50;
            this.lblQuantity.Text = "12";
            this.lblQuantity.Click += new System.EventHandler(this.AllControls_Click);
            this.lblQuantity.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblQuantity.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(858, 55);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 23);
            this.lblPrice.TabIndex = 51;
            this.lblPrice.Text = "213.34";
            this.lblPrice.Click += new System.EventHandler(this.AllControls_Click);
            this.lblPrice.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblPrice.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(858, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "EUR";
            this.label1.Click += new System.EventHandler(this.AllControls_Click);
            this.label1.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.label1.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // ProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbIcon);
            this.Name = "ProductListing";
            this.Size = new System.Drawing.Size(975, 150);
            this.Click += new System.EventHandler(this.AllControls_Click);
            this.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
    }
}
