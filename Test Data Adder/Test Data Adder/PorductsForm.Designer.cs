namespace Test_Data_Adder
{
    partial class PorductsForm
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
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.list = new Test_Data_Adder.List();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.tbLoadCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.Controls.Add(this.list);
            this.flp.Location = new System.Drawing.Point(16, 15);
            this.flp.Margin = new System.Windows.Forms.Padding(4);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(1891, 1338);
            this.flp.TabIndex = 26;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.White;
            this.list.Location = new System.Drawing.Point(5, 5);
            this.list.Margin = new System.Windows.Forms.Padding(5);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(1835, 300);
            this.list.TabIndex = 0;
            this.list.Visible = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(13, 1361);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(201, 72);
            this.btnPrevious.TabIndex = 27;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(222, 1361);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(201, 72);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(432, 1385);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(26, 25);
            this.lblPage.TabIndex = 29;
            this.lblPage.Text = "--";
            // 
            // tbLoadCount
            // 
            this.tbLoadCount.Location = new System.Drawing.Point(1707, 1403);
            this.tbLoadCount.Name = "tbLoadCount";
            this.tbLoadCount.Size = new System.Drawing.Size(196, 31);
            this.tbLoadCount.TabIndex = 30;
            this.tbLoadCount.Leave += new System.EventHandler(this.TbLoadCount_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1703, 1370);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Load Item Count:";
            // 
            // PorductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLoadCount);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.flp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PorductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodcuts List";
            this.Load += new System.EventHandler(this.PorductsForm_Load);
            this.flp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flp;
        private List list;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.TextBox tbLoadCount;
        private System.Windows.Forms.Label label1;
    }
}