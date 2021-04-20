namespace MediaBazaarApp
{
    partial class EmployeeListing
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
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblFirstLast = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.profilePicture = new MediaBazaarApp.ProfilePicture();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeID.Location = new System.Drawing.Point(155, 71);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(155, 21);
            this.lblEmployeeID.TabIndex = 55;
            this.lblEmployeeID.Text = "EMPLOYEEID";
            this.lblEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmployeeID.Click += new System.EventHandler(this.AllControls_Click);
            this.lblEmployeeID.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.lblEmployeeID.MouseLeave += new System.EventHandler(this.ControlsLeave);
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Black;
            this.lblDepartment.Location = new System.Drawing.Point(358, 45);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(156, 38);
            this.lblDepartment.TabIndex = 53;
            this.lblDepartment.Text = "DEPARTMENT";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDepartment.Click += new System.EventHandler(this.AllControls_Click);
            this.lblDepartment.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.lblDepartment.MouseLeave += new System.EventHandler(this.ControlsLeave);
            // 
            // lblFirstLast
            // 
            this.lblFirstLast.AutoSize = true;
            this.lblFirstLast.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstLast.Location = new System.Drawing.Point(155, 33);
            this.lblFirstLast.Name = "lblFirstLast";
            this.lblFirstLast.Size = new System.Drawing.Size(89, 23);
            this.lblFirstLast.TabIndex = 52;
            this.lblFirstLast.Text = "First Last";
            this.lblFirstLast.Click += new System.EventHandler(this.AllControls_Click);
            this.lblFirstLast.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.lblFirstLast.MouseLeave += new System.EventHandler(this.ControlsLeave);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(551, 45);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(210, 38);
            this.lblEmail.TabIndex = 58;
            this.lblEmail.Text = "example@email.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Click += new System.EventHandler(this.AllControls_Click);
            this.lblEmail.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.lblEmail.MouseLeave += new System.EventHandler(this.ControlsLeave);
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(819, 45);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(146, 38);
            this.lblPhone.TabIndex = 59;
            this.lblPhone.Text = "+123456789";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhone.Click += new System.EventHandler(this.AllControls_Click);
            this.lblPhone.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.lblPhone.MouseLeave += new System.EventHandler(this.ControlsLeave);
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(15, 14);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(100, 100);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 57;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.AllControls_Click);
            this.profilePicture.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.profilePicture.MouseLeave += new System.EventHandler(this.ControlsLeave);
            // 
            // EmployeeListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblFirstLast);
            this.Name = "EmployeeListing";
            this.Size = new System.Drawing.Size(990, 130);
            this.Click += new System.EventHandler(this.AllControls_Click);
            this.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.MouseLeave += new System.EventHandler(this.ControlsLeave);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblFirstLast;
        private ProfilePicture profilePicture;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
    }
}
