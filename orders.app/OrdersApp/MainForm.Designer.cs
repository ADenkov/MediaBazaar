namespace OrdersApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.scroller = new System.Windows.Forms.Panel();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton3 = new OrdersApp.RoundButton();
            this.roundButton1 = new OrdersApp.RoundButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.scroller);
            this.leftPanel.Controls.Add(this.btnManagement);
            this.leftPanel.Controls.Add(this.btnOrders);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(6);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(330, 788);
            this.leftPanel.TabIndex = 11;
            // 
            // scroller
            // 
            this.scroller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.scroller.Location = new System.Drawing.Point(0, 0);
            this.scroller.Margin = new System.Windows.Forms.Padding(0);
            this.scroller.Name = "scroller";
            this.scroller.Size = new System.Drawing.Size(3, 129);
            this.scroller.TabIndex = 13;
            this.scroller.Visible = false;
            // 
            // btnManagement
            // 
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManagement.ForeColor = System.Drawing.Color.White;
            this.btnManagement.Location = new System.Drawing.Point(0, 129);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(6);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(330, 129);
            this.btnManagement.TabIndex = 12;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.BtnManagement_Click);
            this.btnManagement.MouseEnter += new System.EventHandler(this.BtnManagement_MouseEnter);
            this.btnManagement.MouseLeave += new System.EventHandler(this.BtnManagement_MouseLeave);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(0, 0);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(6);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(330, 129);
            this.btnOrders.TabIndex = 11;
            this.btnOrders.Text = "Products";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            this.btnOrders.MouseEnter += new System.EventHandler(this.BtnOrders_MouseEnter);
            this.btnOrders.MouseLeave += new System.EventHandler(this.BtnOrders_MouseLeave);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.roundButton3);
            this.topPanel.Controls.Add(this.roundButton1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(330, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(6);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1056, 72);
            this.topPanel.TabIndex = 12;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Media Bazar";
            // 
            // roundButton3
            // 
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Image = ((System.Drawing.Image)(resources.GetObject("roundButton3.Image")));
            this.roundButton3.Location = new System.Drawing.Point(960, 25);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(27, 24);
            this.roundButton3.TabIndex = 3;
            this.roundButton3.UseVisualStyleBackColor = true;
            this.roundButton3.Click += new System.EventHandler(this.RoundButton3_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Image = ((System.Drawing.Image)(resources.GetObject("roundButton1.Image")));
            this.roundButton1.Location = new System.Drawing.Point(1524, 23);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(6);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(54, 46);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.RoundButton1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(330, 72);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1056, 716);
            this.mainPanel.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 129);
            this.button1.TabIndex = 14;
            this.button1.Text = "Statistics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Panel topPanel;
        private RoundButton roundButton1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnManagement;
        private RoundButton roundButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel scroller;
        private System.Windows.Forms.Button button1;
    }
}

