namespace Product_Adder
{
    partial class ProductForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.buttonImage = new System.Windows.Forms.Button();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudDegradation = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDegradation)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "* marks all required feilds to add an item.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Condition:";
            // 
            // cbCondition
            // 
            this.cbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "New",
            "Returned",
            "Open Box",
            "Defective",
            "Missing Items"});
            this.cbCondition.Location = new System.Drawing.Point(42, 262);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(107, 28);
            this.cbCondition.TabIndex = 31;
            // 
            // nudDiscount
            // 
            this.nudDiscount.DecimalPlaces = 2;
            this.nudDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDiscount.Location = new System.Drawing.Point(42, 326);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(107, 26);
            this.nudDiscount.TabIndex = 29;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(38, 303);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(104, 20);
            this.lblDiscount.TabIndex = 30;
            this.lblDiscount.Text = "Discount: (%)";
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrice.Location = new System.Drawing.Point(42, 200);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(107, 26);
            this.nudPrice.TabIndex = 27;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(481, 249);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNote.Size = new System.Drawing.Size(366, 139);
            this.tbNote.TabIndex = 26;
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(193, 177);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(239, 239);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 16;
            this.pbPicture.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(606, 433);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(243, 41);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Add Product";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Department: *";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(193, 43);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(239, 26);
            this.tbName.TabIndex = 1;
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(193, 80);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(239, 26);
            this.tbBrand.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Description:";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(38, 46);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(65, 20);
            this.label123.TabIndex = 8;
            this.label123.Text = "Name: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Brand: *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Note:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(481, 66);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(366, 139);
            this.tbDescription.TabIndex = 22;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(38, 177);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price: *";
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(192, 433);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(243, 41);
            this.buttonImage.TabIndex = 15;
            this.buttonImage.Text = "Upload Image";
            this.buttonImage.UseVisualStyleBackColor = true;
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(193, 544);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(239, 26);
            this.tbProductID.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Store Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 547);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "ProductID:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(193, 507);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(239, 26);
            this.tbAddress.TabIndex = 36;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(193, 581);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(239, 26);
            this.tbDate.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 584);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Date Added:";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(193, 117);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(239, 26);
            this.tbDepartment.TabIndex = 41;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(606, 507);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(243, 41);
            this.buttonRefresh.TabIndex = 42;
            this.buttonRefresh.Text = "Load Next Product";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(606, 554);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(243, 41);
            this.buttonClear.TabIndex = 43;
            this.buttonClear.Text = "Clear Inventory";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(-3, -15);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(898, 23);
            this.pbLoading.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Serial:";
            // 
            // tbSerial
            // 
            this.tbSerial.Enabled = false;
            this.tbSerial.Location = new System.Drawing.Point(193, 618);
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.Size = new System.Drawing.Size(239, 26);
            this.tbSerial.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Degradation: *";
            // 
            // nudDegradation
            // 
            this.nudDegradation.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDegradation.Location = new System.Drawing.Point(42, 390);
            this.nudDegradation.Name = "nudDegradation";
            this.nudDegradation.Size = new System.Drawing.Size(107, 26);
            this.nudDegradation.TabIndex = 48;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 677);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudDegradation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSerial);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.cbCondition);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbBrand);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDegradation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudDegradation;
    }
}