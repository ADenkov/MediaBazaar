namespace MediaBazaarApp
{
    partial class AccountButton
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
            this.components = new System.ComponentModel.Container();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.timerMouseHold = new System.Windows.Forms.Timer(this.components);
            this.profilePicture = new MediaBazaarApp.ProfilePicture();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.lblAccountHolder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHolder.ForeColor = System.Drawing.Color.White;
            this.lblAccountHolder.Location = new System.Drawing.Point(40, 199);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(179, 21);
            this.lblAccountHolder.TabIndex = 2;
            this.lblAccountHolder.Text = "First Last";
            this.lblAccountHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAccountHolder.Click += new System.EventHandler(this.ControlsClick_Click);
            this.lblAccountHolder.MouseEnter += new System.EventHandler(this.MouseEnter_AllControls);
            this.lblAccountHolder.MouseLeave += new System.EventHandler(this.MouseLeave_AllControls);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(75)))));
            this.profilePicture.Location = new System.Drawing.Point(67, 42);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(125, 125);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.ControlsClick_Click);
            this.profilePicture.MouseEnter += new System.EventHandler(this.MouseEnter_AllControls);
            this.profilePicture.MouseLeave += new System.EventHandler(this.MouseLeave_AllControls);
            // 
            // AccountButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.lblAccountHolder);
            this.Controls.Add(this.profilePicture);
            this.Name = "AccountButton";
            this.Size = new System.Drawing.Size(258, 258);
            this.Click += new System.EventHandler(this.ControlsClick_Click);
            this.MouseEnter += new System.EventHandler(this.MouseEnter_AllControls);
            this.MouseLeave += new System.EventHandler(this.MouseLeave_AllControls);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProfilePicture profilePicture;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.Timer timerMouseHold;
    }
}
