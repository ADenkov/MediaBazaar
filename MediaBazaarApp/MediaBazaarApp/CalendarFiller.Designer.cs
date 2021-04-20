namespace MediaBazaarApp
{
    partial class CalendarFiller
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
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblName.Size = new System.Drawing.Size(230, 60);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Longname. F";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Click += new System.EventHandler(this.AllControls_Click);
            this.lblName.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.lblName.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            // 
            // CalendarFiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblName);
            this.Name = "CalendarFiller";
            this.Size = new System.Drawing.Size(230, 60);
            this.Click += new System.EventHandler(this.AllControls_Click);
            this.MouseEnter += new System.EventHandler(this.AllControls_Enter);
            this.MouseLeave += new System.EventHandler(this.AllControls_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
    }
}
