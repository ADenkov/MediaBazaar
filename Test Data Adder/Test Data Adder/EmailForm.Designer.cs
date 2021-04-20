namespace Test_Data_Adder
{
    partial class EmailForm
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
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(133, 113);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(609, 26);
            this.tbSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(133, 151);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(609, 237);
            this.tbMessage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Message:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(567, 415);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(175, 46);
            this.buttonSend.TabIndex = 16;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // tbCC
            // 
            this.tbCC.Location = new System.Drawing.Point(133, 76);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(609, 26);
            this.tbCC.TabIndex = 8;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(133, 39);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(609, 26);
            this.tbTo.TabIndex = 9;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 486);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSubject);
            this.Name = "EmailForm";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.TextBox tbTo;
    }
}