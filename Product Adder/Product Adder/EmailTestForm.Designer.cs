namespace Product_Adder
{
    partial class EmailTestForm
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
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnPerChar = new System.Windows.Forms.Button();
            this.nudChar = new System.Windows.Forms.NumericUpDown();
            this.tbActual = new System.Windows.Forms.TextBox();
            this.btnPerWord = new System.Windows.Forms.Button();
            this.nudWord = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWord)).BeginInit();
            this.SuspendLayout();
            // 
            // tbContent
            // 
            this.tbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContent.Location = new System.Drawing.Point(12, 12);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(1781, 438);
            this.tbContent.TabIndex = 111;
            // 
            // btnPerChar
            // 
            this.btnPerChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerChar.Location = new System.Drawing.Point(1550, 680);
            this.btnPerChar.Name = "btnPerChar";
            this.btnPerChar.Size = new System.Drawing.Size(243, 42);
            this.btnPerChar.TabIndex = 75;
            this.btnPerChar.Text = "Per Char";
            this.btnPerChar.UseVisualStyleBackColor = true;
            this.btnPerChar.Click += new System.EventHandler(this.BtnPerChar_Click);
            // 
            // nudChar
            // 
            this.nudChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudChar.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudChar.Location = new System.Drawing.Point(1552, 643);
            this.nudChar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudChar.Name = "nudChar";
            this.nudChar.Size = new System.Drawing.Size(239, 26);
            this.nudChar.TabIndex = 77;
            this.nudChar.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // tbActual
            // 
            this.tbActual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbActual.Location = new System.Drawing.Point(12, 466);
            this.tbActual.Multiline = true;
            this.tbActual.Name = "tbActual";
            this.tbActual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbActual.Size = new System.Drawing.Size(1781, 157);
            this.tbActual.TabIndex = 112;
            // 
            // btnPerWord
            // 
            this.btnPerWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerWord.Location = new System.Drawing.Point(1282, 680);
            this.btnPerWord.Name = "btnPerWord";
            this.btnPerWord.Size = new System.Drawing.Size(243, 42);
            this.btnPerWord.TabIndex = 113;
            this.btnPerWord.Text = "Per Word";
            this.btnPerWord.UseVisualStyleBackColor = true;
            this.btnPerWord.Click += new System.EventHandler(this.BtnPerWord_Click);
            // 
            // nudWord
            // 
            this.nudWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWord.Location = new System.Drawing.Point(1284, 643);
            this.nudWord.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWord.Name = "nudWord";
            this.nudWord.Size = new System.Drawing.Size(239, 26);
            this.nudWord.TabIndex = 114;
            this.nudWord.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // EmailTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 743);
            this.Controls.Add(this.btnPerWord);
            this.Controls.Add(this.nudWord);
            this.Controls.Add(this.tbActual);
            this.Controls.Add(this.btnPerChar);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.nudChar);
            this.Name = "EmailTestForm";
            this.Text = "EmailTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button btnPerChar;
        private System.Windows.Forms.NumericUpDown nudChar;
        private System.Windows.Forms.TextBox tbActual;
        private System.Windows.Forms.Button btnPerWord;
        private System.Windows.Forms.NumericUpDown nudWord;
    }
}