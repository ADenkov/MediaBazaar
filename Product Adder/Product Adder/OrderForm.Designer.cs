namespace Product_Adder
{
    partial class OrderForm
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
            this.btnDOSHIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDOSHIT
            // 
            this.btnDOSHIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDOSHIT.Location = new System.Drawing.Point(12, 12);
            this.btnDOSHIT.Name = "btnDOSHIT";
            this.btnDOSHIT.Size = new System.Drawing.Size(776, 426);
            this.btnDOSHIT.TabIndex = 0;
            this.btnDOSHIT.Text = "GENERATE ORDERS";
            this.btnDOSHIT.UseVisualStyleBackColor = true;
            this.btnDOSHIT.Click += new System.EventHandler(this.BtnDOSHIT_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDOSHIT);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDOSHIT;
    }
}