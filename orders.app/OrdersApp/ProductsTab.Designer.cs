namespace OrdersApp
{
    partial class ProductsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsTab));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Department = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblPrev = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStore = new System.Windows.Forms.Label();
            this.label1230 = new System.Windows.Forms.Label();
            this.flpOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.flpInStock = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.Department);
            this.panel1.Controls.Add(this.cbLocation);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNext);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.lblPrev);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnMakeOrder);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flpOrder);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label63);
            this.panel1.Controls.Add(this.flpInStock);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 678);
            this.panel1.TabIndex = 2;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Department.Location = new System.Drawing.Point(323, 14);
            this.Department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(41, 17);
            this.Department.TabIndex = 77;
            this.Department.Text = "Store";
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(372, 14);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(245, 21);
            this.cbLocation.TabIndex = 76;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label17.Location = new System.Drawing.Point(27, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 18);
            this.label17.TabIndex = 65;
            this.label17.Text = "Product";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label10.Location = new System.Drawing.Point(72, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 23);
            this.label10.TabIndex = 62;
            this.label10.Text = "Make An Order";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(472, 89);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 65);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label6.Location = new System.Drawing.Point(145, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 75;
            this.label6.Text = "Availability";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(544, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "For Delivery";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNext.ForeColor = System.Drawing.Color.Black;
            this.lblNext.Location = new System.Drawing.Point(414, 639);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(49, 16);
            this.lblNext.TabIndex = 74;
            this.lblNext.Text = "Next >";
            this.lblNext.Click += new System.EventHandler(this.LblNext_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(472, 158);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(67, 65);
            this.btnRemove.TabIndex = 69;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // lblPrev
            // 
            this.lblPrev.AutoSize = true;
            this.lblPrev.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrev.ForeColor = System.Drawing.Color.Black;
            this.lblPrev.Location = new System.Drawing.Point(18, 639);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(73, 16);
            this.lblPrev.TabIndex = 24;
            this.lblPrev.Text = "< Previous";
            this.lblPrev.Click += new System.EventHandler(this.LblPrev_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(643, 376);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 46);
            this.btnCancel.TabIndex = 73;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(89)))), ((int)(((byte)(220)))));
            this.btnMakeOrder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeOrder.ForeColor = System.Drawing.Color.White;
            this.btnMakeOrder.Location = new System.Drawing.Point(547, 376);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(92, 46);
            this.btnMakeOrder.TabIndex = 72;
            this.btnMakeOrder.Text = "Make order";
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.BtnMakeOrder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblStore);
            this.panel2.Controls.Add(this.label1230);
            this.panel2.Location = new System.Drawing.Point(547, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 187);
            this.panel2.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label7.Location = new System.Drawing.Point(93, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 14);
            this.label7.TabIndex = 30;
            this.label7.Text = "Example address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label8.Location = new System.Drawing.Point(12, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Delivery:";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(261, 56);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(154, 16);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "0.00 EUR";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Order Overview:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.panel3.Location = new System.Drawing.Point(15, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 3);
            this.panel3.TabIndex = 25;
            // 
            // lblStore
            // 
            this.lblStore.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblStore.Location = new System.Drawing.Point(93, 98);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(175, 14);
            this.lblStore.TabIndex = 24;
            this.lblStore.Text = "store address example 1234";
            // 
            // label1230
            // 
            this.label1230.AutoSize = true;
            this.label1230.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1230.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label1230.Location = new System.Drawing.Point(12, 98);
            this.label1230.Name = "label1230";
            this.label1230.Size = new System.Drawing.Size(65, 16);
            this.label1230.TabIndex = 23;
            this.label1230.Text = "Address:";
            // 
            // flpOrder
            // 
            this.flpOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpOrder.AutoScroll = true;
            this.flpOrder.Location = new System.Drawing.Point(547, 89);
            this.flpOrder.Margin = new System.Windows.Forms.Padding(2);
            this.flpOrder.Name = "flpOrder";
            this.flpOrder.Size = new System.Drawing.Size(453, 274);
            this.flpOrder.TabIndex = 67;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(471, 227);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 42);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label63.Location = new System.Drawing.Point(369, 68);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(70, 18);
            this.label63.TabIndex = 66;
            this.label63.Text = "Quantity";
            // 
            // flpInStock
            // 
            this.flpInStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpInStock.AutoScroll = true;
            this.flpInStock.Location = new System.Drawing.Point(23, 89);
            this.flpInStock.Margin = new System.Windows.Forms.Padding(2);
            this.flpInStock.Name = "flpInStock";
            this.flpInStock.Size = new System.Drawing.Size(440, 538);
            this.flpInStock.TabIndex = 64;
            // 
            // ProductsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 702);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsTab";
            this.Text = "OrdersTab";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblPrev;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label label1230;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpOrder;
        private System.Windows.Forms.FlowLayoutPanel flpInStock;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}