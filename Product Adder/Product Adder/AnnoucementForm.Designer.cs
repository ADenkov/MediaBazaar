namespace Product_Adder
{
    partial class AnnoucementForm
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
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.cbAdm = new System.Windows.Forms.CheckBox();
            this.cbMan = new System.Windows.Forms.CheckBox();
            this.cbFlo = new System.Windows.Forms.CheckBox();
            this.cbWar = new System.Windows.Forms.CheckBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(201, 84);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(537, 26);
            this.tbSubject.TabIndex = 1;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(201, 121);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(537, 155);
            this.tbMessage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "From Depart.: *";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Floor Employee",
            "Warehouse Worker"});
            this.cbDepartment.Location = new System.Drawing.Point(201, 35);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(240, 28);
            this.cbDepartment.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Subject: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Messae: *";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(495, 366);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(243, 42);
            this.buttonAdd.TabIndex = 64;
            this.buttonAdd.Text = "Add Anoucement";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // cbAdm
            // 
            this.cbAdm.AutoSize = true;
            this.cbAdm.Location = new System.Drawing.Point(201, 331);
            this.cbAdm.Name = "cbAdm";
            this.cbAdm.Size = new System.Drawing.Size(147, 24);
            this.cbAdm.TabIndex = 65;
            this.cbAdm.Text = "Adminsitrator(s)";
            this.cbAdm.UseVisualStyleBackColor = true;
            // 
            // cbMan
            // 
            this.cbMan.AutoSize = true;
            this.cbMan.Location = new System.Drawing.Point(201, 363);
            this.cbMan.Name = "cbMan";
            this.cbMan.Size = new System.Drawing.Size(116, 24);
            this.cbMan.TabIndex = 66;
            this.cbMan.Text = "Manager(s)";
            this.cbMan.UseVisualStyleBackColor = true;
            // 
            // cbFlo
            // 
            this.cbFlo.AutoSize = true;
            this.cbFlo.Location = new System.Drawing.Point(201, 396);
            this.cbFlo.Name = "cbFlo";
            this.cbFlo.Size = new System.Drawing.Size(145, 24);
            this.cbFlo.TabIndex = 67;
            this.cbFlo.Text = "Floor Employee";
            this.cbFlo.UseVisualStyleBackColor = true;
            // 
            // cbWar
            // 
            this.cbWar.AutoSize = true;
            this.cbWar.Location = new System.Drawing.Point(201, 429);
            this.cbWar.Name = "cbWar";
            this.cbWar.Size = new System.Drawing.Size(172, 24);
            this.cbWar.TabIndex = 68;
            this.cbWar.Text = "Warehouse Worker";
            this.cbWar.UseVisualStyleBackColor = true;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(201, 287);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(537, 28);
            this.cbLocation.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Store:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(495, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(243, 42);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(497, 329);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(239, 26);
            this.tbCount.TabIndex = 72;
            this.tbCount.Text = "20";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(499, 21);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(243, 42);
            this.btnGenerate.TabIndex = 73;
            this.btnGenerate.Text = "Generate Text";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // AnnoucementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.cbWar);
            this.Controls.Add(this.cbFlo);
            this.Controls.Add(this.cbMan);
            this.Controls.Add(this.cbAdm);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbSubject);
            this.Name = "AnnoucementForm";
            this.Text = "AnnoucementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox cbAdm;
        private System.Windows.Forms.CheckBox cbMan;
        private System.Windows.Forms.CheckBox cbFlo;
        private System.Windows.Forms.CheckBox cbWar;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Button btnGenerate;
    }
}