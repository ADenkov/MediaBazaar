namespace MediaBazaarApp
{
    partial class NewLocationEmployeeListing
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Black;
            this.lblDepartment.Location = new System.Drawing.Point(415, 23);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(156, 38);
            this.lblDepartment.TabIndex = 53;
            this.lblDepartment.Text = "DEPARTMENT";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDepartment.Click += new System.EventHandler(this.ControlsClick_Clicked);
            this.lblDepartment.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.lblDepartment.MouseLeave += new System.EventHandler(this.ControlsLeave);
            // 
            // lblStore
            // 
            this.lblStore.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStore.ForeColor = System.Drawing.Color.Black;
            this.lblStore.Location = new System.Drawing.Point(682, 23);
            this.lblStore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(390, 38);
            this.lblStore.TabIndex = 58;
            this.lblStore.Text = "Address 1234 example store";
            this.lblStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStore.Click += new System.EventHandler(this.ControlsClick_Clicked);
            this.lblStore.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.lblStore.MouseLeave += new System.EventHandler(this.ControlsLeave);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeID.Location = new System.Drawing.Point(215, 23);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(156, 38);
            this.lblEmployeeID.TabIndex = 59;
            this.lblEmployeeID.Text = "EMPLOYEEID";
            this.lblEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmployeeID.Click += new System.EventHandler(this.ControlsClick_Clicked);
            this.lblEmployeeID.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.lblEmployeeID.MouseLeave += new System.EventHandler(this.ControlsLeave);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(21, 23);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(156, 38);
            this.lblName.TabIndex = 60;
            this.lblName.Text = "FIRST L.";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Click += new System.EventHandler(this.ControlsClick_Clicked);
            this.lblName.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.ControlsLeave);
            // 
            // NewLocationEmployeeListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.lblDepartment);
            this.Name = "NewLocationEmployeeListing";
            this.Size = new System.Drawing.Size(1100, 80);
            this.Click += new System.EventHandler(this.ControlsClick_Clicked);
            this.MouseEnter += new System.EventHandler(this.ControlsEnter);
            this.MouseLeave += new System.EventHandler(this.ControlsLeave);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblName;
    }
}
