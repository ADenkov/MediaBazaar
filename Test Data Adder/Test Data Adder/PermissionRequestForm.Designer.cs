namespace Test_Data_Adder
{
    partial class PermissionRequestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Password to make changes:";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Verdana", 10F);
            this.tbPassword.Location = new System.Drawing.Point(48, 74);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(254, 32);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(308, 72);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(131, 41);
            this.btnConfirm.TabIndex = 38;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // PermissionRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 171);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label1);
            this.Name = "PermissionRequestForm";
            this.Text = "Permission Required";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnConfirm;
    }
}