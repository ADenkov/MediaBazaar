namespace Product_Adder
{
    partial class MainForm
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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnAnnoucement = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(12, 12);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(130, 130);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(148, 12);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(130, 130);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // btnAnnoucement
            // 
            this.btnAnnoucement.Location = new System.Drawing.Point(12, 148);
            this.btnAnnoucement.Name = "btnAnnoucement";
            this.btnAnnoucement.Size = new System.Drawing.Size(130, 130);
            this.btnAnnoucement.TabIndex = 2;
            this.btnAnnoucement.Text = "Annoucements";
            this.btnAnnoucement.UseVisualStyleBackColor = true;
            this.btnAnnoucement.Click += new System.EventHandler(this.BtnAnnoucement_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(148, 148);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(130, 130);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(12, 284);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(266, 130);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.BtnSchedule_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 422);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnAnnoucement);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnEmployee);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnAnnoucement;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnSchedule;
    }
}