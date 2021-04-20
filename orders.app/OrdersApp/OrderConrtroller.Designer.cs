namespace OrdersApp
{
    partial class OrderConrtroller
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblCosts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(174, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 17);
            this.lblDate.TabIndex = 54;
            this.lblDate.Text = "PRODUCT_ID";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(20, 13);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(105, 17);
            this.lblOrderID.TabIndex = 53;
            this.lblOrderID.Text = "Product Name";
            // 
            // lblCosts
            // 
            this.lblCosts.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosts.Location = new System.Drawing.Point(333, 12);
            this.lblCosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCosts.Name = "lblCosts";
            this.lblCosts.Size = new System.Drawing.Size(152, 17);
            this.lblCosts.TabIndex = 55;
            this.lblCosts.Text = "0.00 EUR";
            this.lblCosts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderConrtroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblCosts);
            this.Name = "OrderConrtroller";
            this.Size = new System.Drawing.Size(509, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblCosts;
    }
}
