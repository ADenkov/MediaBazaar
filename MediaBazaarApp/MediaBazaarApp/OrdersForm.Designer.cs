namespace MediaBazaarApp
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.pMain = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flpOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.flpInStock = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pLocations = new System.Windows.Forms.Panel();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbForwardEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.cbDefault = new System.Windows.Forms.CheckBox();
            this.cbForward = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStoreTel = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.label1230 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.btnClear);
            this.pMain.Controls.Add(this.lblPage);
            this.pMain.Controls.Add(this.btnAdd);
            this.pMain.Controls.Add(this.btnRemove);
            this.pMain.Controls.Add(this.label1);
            this.pMain.Controls.Add(this.flpOrder);
            this.pMain.Controls.Add(this.flpInStock);
            this.pMain.Controls.Add(this.btnNext);
            this.pMain.Controls.Add(this.btnPrevious);
            this.pMain.Controls.Add(this.label63);
            this.pMain.Controls.Add(this.btnSubmitOrder);
            this.pMain.Controls.Add(this.label17);
            this.pMain.Controls.Add(this.pictureBox1);
            this.pMain.Controls.Add(this.label10);
            this.pMain.Location = new System.Drawing.Point(15, 18);
            this.pMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1092, 761);
            this.pMain.TabIndex = 32;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(496, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 49);
            this.btnClear.TabIndex = 61;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPage.ForeColor = System.Drawing.Color.Black;
            this.lblPage.Location = new System.Drawing.Point(368, 891);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(122, 21);
            this.lblPage.TabIndex = 62;
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(496, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 100);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(496, 246);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 100);
            this.btnRemove.TabIndex = 59;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(597, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 58;
            this.label1.Text = "For Delivery";
            // 
            // flpOrder
            // 
            this.flpOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpOrder.AutoScroll = true;
            this.flpOrder.Location = new System.Drawing.Point(602, 140);
            this.flpOrder.Name = "flpOrder";
            this.flpOrder.Size = new System.Drawing.Size(460, 511);
            this.flpOrder.TabIndex = 57;
            // 
            // flpInStock
            // 
            this.flpInStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpInStock.AutoScroll = true;
            this.flpInStock.Location = new System.Drawing.Point(30, 140);
            this.flpInStock.Name = "flpInStock";
            this.flpInStock.Size = new System.Drawing.Size(460, 511);
            this.flpInStock.TabIndex = 29;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(157, 878);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 49);
            this.btnNext.TabIndex = 54;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(30, 878);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(121, 49);
            this.btnPrevious.TabIndex = 53;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label63.Location = new System.Drawing.Point(341, 107);
            this.label63.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(100, 27);
            this.label63.TabIndex = 48;
            this.label63.Text = "In Stock";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitOrder.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.Location = new System.Drawing.Point(602, 878);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(460, 49);
            this.btnSubmitOrder.TabIndex = 55;
            this.btnSubmitOrder.Text = "Request Delivery";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.BtnSubmitOrder_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label17.Location = new System.Drawing.Point(57, 107);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 27);
            this.label17.TabIndex = 47;
            this.label17.Text = "Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label10.Location = new System.Drawing.Point(113, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 36);
            this.label10.TabIndex = 5;
            this.label10.Text = "Make Order";
            // 
            // pLocations
            // 
            this.pLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pLocations.BackColor = System.Drawing.Color.White;
            this.pLocations.Controls.Add(this.label2);
            this.pLocations.Controls.Add(this.btnNewSupplier);
            this.pLocations.Controls.Add(this.cbSupplier);
            this.pLocations.Controls.Add(this.label7);
            this.pLocations.Controls.Add(this.label5);
            this.pLocations.Controls.Add(this.tbForwardEmail);
            this.pLocations.Controls.Add(this.label6);
            this.pLocations.Controls.Add(this.lblTotal);
            this.pLocations.Controls.Add(this.lblNote);
            this.pLocations.Controls.Add(this.cbDefault);
            this.pLocations.Controls.Add(this.cbForward);
            this.pLocations.Controls.Add(this.label4);
            this.pLocations.Controls.Add(this.dtpDelivery);
            this.pLocations.Controls.Add(this.label3);
            this.pLocations.Controls.Add(this.lblStoreTel);
            this.pLocations.Controls.Add(this.lblStore);
            this.pLocations.Controls.Add(this.label1230);
            this.pLocations.Controls.Add(this.pictureBox4);
            this.pLocations.Controls.Add(this.label37);
            this.pLocations.Controls.Add(this.tbNote);
            this.pLocations.Location = new System.Drawing.Point(1120, 18);
            this.pLocations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pLocations.Name = "pLocations";
            this.pLocations.Size = new System.Drawing.Size(512, 761);
            this.pLocations.TabIndex = 31;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSupplier.Location = new System.Drawing.Point(299, 312);
            this.btnNewSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(181, 42);
            this.btnNewSupplier.TabIndex = 63;
            this.btnNewSupplier.Text = "New Supplier";
            this.btnNewSupplier.UseVisualStyleBackColor = true;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSupplier.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(39, 270);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(437, 29);
            this.cbSupplier.TabIndex = 127;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label7.Location = new System.Drawing.Point(300, 668);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 21);
            this.label7.TabIndex = 126;
            this.label7.Text = "(optional)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label5.Location = new System.Drawing.Point(35, 666);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 23);
            this.label5.TabIndex = 125;
            this.label5.Text = "Add Delivery Note:";
            // 
            // tbForwardEmail
            // 
            this.tbForwardEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbForwardEmail.Enabled = false;
            this.tbForwardEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbForwardEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbForwardEmail.Location = new System.Drawing.Point(39, 580);
            this.tbForwardEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbForwardEmail.Name = "tbForwardEmail";
            this.tbForwardEmail.Size = new System.Drawing.Size(437, 30);
            this.tbForwardEmail.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label6.Location = new System.Drawing.Point(35, 434);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 121;
            this.label6.Text = "Order Report:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblTotal.Location = new System.Drawing.Point(213, 373);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(263, 21);
            this.lblTotal.TabIndex = 120;
            this.lblTotal.Text = "-- EUR";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Enabled = false;
            this.lblNote.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblNote.Location = new System.Drawing.Point(214, 615);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(262, 21);
            this.lblNote.TabIndex = 117;
            this.lblNote.Text = "*separate emails with spaces";
            // 
            // cbDefault
            // 
            this.cbDefault.AutoSize = true;
            this.cbDefault.Checked = true;
            this.cbDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefault.Enabled = false;
            this.cbDefault.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.cbDefault.Location = new System.Drawing.Point(39, 479);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(333, 25);
            this.cbDefault.TabIndex = 115;
            this.cbDefault.Text = "    Default (greffnoah@gmail.com)";
            this.cbDefault.UseVisualStyleBackColor = true;
            // 
            // cbForward
            // 
            this.cbForward.AutoSize = true;
            this.cbForward.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbForward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.cbForward.Location = new System.Drawing.Point(39, 541);
            this.cbForward.Name = "cbForward";
            this.cbForward.Size = new System.Drawing.Size(155, 25);
            this.cbForward.TabIndex = 116;
            this.cbForward.Text = "    Forward To:";
            this.cbForward.UseVisualStyleBackColor = true;
            this.cbForward.CheckedChanged += new System.EventHandler(this.CbForward_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(35, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 112;
            this.label4.Text = "Total:";
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Location = new System.Drawing.Point(203, 169);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(273, 26);
            this.dtpDelivery.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label3.Location = new System.Drawing.Point(35, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Delivery Date:";
            // 
            // lblStoreTel
            // 
            this.lblStoreTel.AutoSize = true;
            this.lblStoreTel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStoreTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblStoreTel.Location = new System.Drawing.Point(199, 129);
            this.lblStoreTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStoreTel.Name = "lblStoreTel";
            this.lblStoreTel.Size = new System.Drawing.Size(101, 21);
            this.lblStoreTel.TabIndex = 23;
            this.lblStoreTel.Text = "+12345678";
            // 
            // lblStore
            // 
            this.lblStore.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblStore.Location = new System.Drawing.Point(199, 98);
            this.lblStore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(263, 21);
            this.lblStore.TabIndex = 22;
            this.lblStore.Text = "store address example 1234";
            // 
            // label1230
            // 
            this.label1230.AutoSize = true;
            this.label1230.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1230.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label1230.Location = new System.Drawing.Point(35, 96);
            this.label1230.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1230.Name = "label1230";
            this.label1230.Size = new System.Drawing.Size(148, 23);
            this.label1230.TabIndex = 21;
            this.label1230.Text = "Store Address:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(39, 24);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label37.Location = new System.Drawing.Point(113, 24);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(120, 36);
            this.label37.TabIndex = 5;
            this.label37.Text = "Invoice";
            // 
            // tbNote
            // 
            this.tbNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbNote.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbNote.Location = new System.Drawing.Point(39, 699);
            this.tbNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNote.Size = new System.Drawing.Size(437, 175);
            this.tbNote.TabIndex = 124;
            this.tbNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbNote_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label2.Location = new System.Drawing.Point(34, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 23);
            this.label2.TabIndex = 128;
            this.label2.Text = "Supplier: (required)";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1645, 778);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pLocations.ResumeLayout(false);
            this.pLocations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.FlowLayoutPanel flpInStock;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pLocations;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStoreTel;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label label1230;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.FlowLayoutPanel flpOrder;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.CheckBox cbDefault;
        private System.Windows.Forms.CheckBox cbForward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbForwardEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label2;
    }
}