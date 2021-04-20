namespace MediaBazaarApp
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.Scroller = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnServerSettings = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.pt = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.Panel();
            this.pSubmenuAnnoucements = new System.Windows.Forms.Panel();
            this.btnNewAnnoucement = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.btnAnnoucements = new System.Windows.Forms.Button();
            this.pSubmenuInventory = new System.Windows.Forms.Panel();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pSubmenuLocations = new System.Windows.Forms.Panel();
            this.btnNewLocation = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblTabName = new System.Windows.Forms.Label();
            this.picBoxTab = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pServerSettings = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnAccount = new MediaBazaarApp.AccountButton();
            this.SidePanel.SuspendLayout();
            this.pSubmenuAnnoucements.SuspendLayout();
            this.pSubmenuInventory.SuspendLayout();
            this.pSubmenuLocations.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTab)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.pServerSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(0, 983);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(258, 58);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Scroller
            // 
            this.Scroller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Scroller.Location = new System.Drawing.Point(0, 0);
            this.Scroller.Name = "Scroller";
            this.Scroller.Size = new System.Drawing.Size(4, 258);
            this.Scroller.TabIndex = 9;
            this.Scroller.Visible = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.SidePanel.Controls.Add(this.btnServerSettings);
            this.SidePanel.Controls.Add(this.tbUsername);
            this.SidePanel.Controls.Add(this.pt);
            this.SidePanel.Controls.Add(this.tbPassword);
            this.SidePanel.Controls.Add(this.pb);
            this.SidePanel.Controls.Add(this.pSubmenuAnnoucements);
            this.SidePanel.Controls.Add(this.btnAnnoucements);
            this.SidePanel.Controls.Add(this.pSubmenuInventory);
            this.SidePanel.Controls.Add(this.btnInventory);
            this.SidePanel.Controls.Add(this.pSubmenuLocations);
            this.SidePanel.Controls.Add(this.btnLogin);
            this.SidePanel.Controls.Add(this.btnLocations);
            this.SidePanel.Controls.Add(this.btnDashboard);
            this.SidePanel.Controls.Add(this.btnAccount);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(258, 1041);
            this.SidePanel.TabIndex = 10;
            // 
            // btnServerSettings
            // 
            this.btnServerSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnServerSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServerSettings.FlatAppearance.BorderSize = 0;
            this.btnServerSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerSettings.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnServerSettings.Location = new System.Drawing.Point(0, 1043);
            this.btnServerSettings.Name = "btnServerSettings";
            this.btnServerSettings.Size = new System.Drawing.Size(258, 80);
            this.btnServerSettings.TabIndex = 19;
            this.btnServerSettings.Text = "Server Settings";
            this.btnServerSettings.UseVisualStyleBackColor = false;
            this.btnServerSettings.Click += new System.EventHandler(this.BtnServerSettings_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.White;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbUsername.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.DimGray;
            this.tbUsername.Location = new System.Drawing.Point(0, 899);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(258, 32);
            this.tbUsername.TabIndex = 0;
            // 
            // pt
            // 
            this.pt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pt.Location = new System.Drawing.Point(0, 931);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(258, 10);
            this.pt.TabIndex = 28;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbPassword.Location = new System.Drawing.Point(0, 941);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(258, 32);
            this.tbPassword.TabIndex = 1;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb.Location = new System.Drawing.Point(0, 973);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(258, 10);
            this.pb.TabIndex = 26;
            // 
            // pSubmenuAnnoucements
            // 
            this.pSubmenuAnnoucements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pSubmenuAnnoucements.Controls.Add(this.btnNewAnnoucement);
            this.pSubmenuAnnoucements.Controls.Add(this.btnInbox);
            this.pSubmenuAnnoucements.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmenuAnnoucements.Location = new System.Drawing.Point(0, 933);
            this.pSubmenuAnnoucements.Name = "pSubmenuAnnoucements";
            this.pSubmenuAnnoucements.Size = new System.Drawing.Size(258, 110);
            this.pSubmenuAnnoucements.TabIndex = 23;
            // 
            // btnNewAnnoucement
            // 
            this.btnNewAnnoucement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.btnNewAnnoucement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewAnnoucement.FlatAppearance.BorderSize = 0;
            this.btnNewAnnoucement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAnnoucement.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAnnoucement.ForeColor = System.Drawing.Color.White;
            this.btnNewAnnoucement.Location = new System.Drawing.Point(0, 55);
            this.btnNewAnnoucement.Name = "btnNewAnnoucement";
            this.btnNewAnnoucement.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNewAnnoucement.Size = new System.Drawing.Size(258, 55);
            this.btnNewAnnoucement.TabIndex = 20;
            this.btnNewAnnoucement.Text = "New Annoucement";
            this.btnNewAnnoucement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAnnoucement.UseVisualStyleBackColor = false;
            this.btnNewAnnoucement.Click += new System.EventHandler(this.BtnNewAnnoucement_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.btnInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInbox.FlatAppearance.BorderSize = 0;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInbox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.ForeColor = System.Drawing.Color.White;
            this.btnInbox.Location = new System.Drawing.Point(0, 0);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnInbox.Size = new System.Drawing.Size(258, 55);
            this.btnInbox.TabIndex = 19;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.UseVisualStyleBackColor = false;
            this.btnInbox.Click += new System.EventHandler(this.BtnInbox_Click);
            // 
            // btnAnnoucements
            // 
            this.btnAnnoucements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnAnnoucements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnoucements.FlatAppearance.BorderSize = 0;
            this.btnAnnoucements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnoucements.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnoucements.ForeColor = System.Drawing.Color.White;
            this.btnAnnoucements.Location = new System.Drawing.Point(0, 833);
            this.btnAnnoucements.Name = "btnAnnoucements";
            this.btnAnnoucements.Size = new System.Drawing.Size(258, 100);
            this.btnAnnoucements.TabIndex = 22;
            this.btnAnnoucements.Text = "Annoucements";
            this.btnAnnoucements.UseVisualStyleBackColor = false;
            this.btnAnnoucements.Click += new System.EventHandler(this.BtnAnnoucements_Click);
            // 
            // pSubmenuInventory
            // 
            this.pSubmenuInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pSubmenuInventory.Controls.Add(this.btnNewProduct);
            this.pSubmenuInventory.Controls.Add(this.btnOrders);
            this.pSubmenuInventory.Controls.Add(this.btnStock);
            this.pSubmenuInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmenuInventory.Location = new System.Drawing.Point(0, 668);
            this.pSubmenuInventory.Name = "pSubmenuInventory";
            this.pSubmenuInventory.Size = new System.Drawing.Size(258, 165);
            this.pSubmenuInventory.TabIndex = 21;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.btnNewProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewProduct.FlatAppearance.BorderSize = 0;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnNewProduct.Location = new System.Drawing.Point(0, 110);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNewProduct.Size = new System.Drawing.Size(258, 55);
            this.btnNewProduct.TabIndex = 19;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.BtnNewProduct_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(0, 55);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(258, 55);
            this.btnOrders.TabIndex = 18;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(0, 0);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(258, 55);
            this.btnStock.TabIndex = 17;
            this.btnStock.Text = "Stocks";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(0, 568);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(258, 100);
            this.btnInventory.TabIndex = 20;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // pSubmenuLocations
            // 
            this.pSubmenuLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.pSubmenuLocations.Controls.Add(this.btnNewLocation);
            this.pSubmenuLocations.Controls.Add(this.btnGeneral);
            this.pSubmenuLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSubmenuLocations.Location = new System.Drawing.Point(0, 458);
            this.pSubmenuLocations.Name = "pSubmenuLocations";
            this.pSubmenuLocations.Size = new System.Drawing.Size(258, 110);
            this.pSubmenuLocations.TabIndex = 19;
            // 
            // btnNewLocation
            // 
            this.btnNewLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.btnNewLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewLocation.FlatAppearance.BorderSize = 0;
            this.btnNewLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLocation.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLocation.ForeColor = System.Drawing.Color.White;
            this.btnNewLocation.Location = new System.Drawing.Point(0, 55);
            this.btnNewLocation.Name = "btnNewLocation";
            this.btnNewLocation.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNewLocation.Size = new System.Drawing.Size(258, 55);
            this.btnNewLocation.TabIndex = 18;
            this.btnNewLocation.Text = "New Location";
            this.btnNewLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewLocation.UseVisualStyleBackColor = false;
            this.btnNewLocation.Click += new System.EventHandler(this.BtnNewLocation_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.Color.White;
            this.btnGeneral.Location = new System.Drawing.Point(0, 0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGeneral.Size = new System.Drawing.Size(258, 55);
            this.btnGeneral.TabIndex = 17;
            this.btnGeneral.Text = "General";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.BtnGeneral_Click);
            // 
            // btnLocations
            // 
            this.btnLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocations.FlatAppearance.BorderSize = 0;
            this.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocations.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocations.ForeColor = System.Drawing.Color.White;
            this.btnLocations.Location = new System.Drawing.Point(0, 358);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(258, 100);
            this.btnLocations.TabIndex = 12;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = false;
            this.btnLocations.Click += new System.EventHandler(this.BtnLocations_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 258);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(258, 100);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.TopPanel.Controls.Add(this.lblTabName);
            this.TopPanel.Controls.Add(this.picBoxTab);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(258, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1651, 65);
            this.TopPanel.TabIndex = 11;
            this.TopPanel.Visible = false;
            // 
            // lblTabName
            // 
            this.lblTabName.AutoSize = true;
            this.lblTabName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTabName.ForeColor = System.Drawing.Color.White;
            this.lblTabName.Location = new System.Drawing.Point(69, 14);
            this.lblTabName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTabName.Name = "lblTabName";
            this.lblTabName.Size = new System.Drawing.Size(136, 36);
            this.lblTabName.TabIndex = 10;
            this.lblTabName.Text = "Account";
            // 
            // picBoxTab
            // 
            this.picBoxTab.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTab.Image")));
            this.picBoxTab.Location = new System.Drawing.Point(22, 14);
            this.picBoxTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBoxTab.Name = "picBoxTab";
            this.picBoxTab.Size = new System.Drawing.Size(38, 38);
            this.picBoxTab.TabIndex = 9;
            this.picBoxTab.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pServerSettings);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(258, 65);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1651, 976);
            this.MainPanel.TabIndex = 12;
            // 
            // pServerSettings
            // 
            this.pServerSettings.BackColor = System.Drawing.Color.White;
            this.pServerSettings.Controls.Add(this.btnClose);
            this.pServerSettings.Controls.Add(this.label3);
            this.pServerSettings.Controls.Add(this.tbPass);
            this.pServerSettings.Controls.Add(this.label2);
            this.pServerSettings.Controls.Add(this.tbUser);
            this.pServerSettings.Controls.Add(this.label1);
            this.pServerSettings.Controls.Add(this.tbDB);
            this.pServerSettings.Controls.Add(this.label37);
            this.pServerSettings.Controls.Add(this.label6);
            this.pServerSettings.Controls.Add(this.tbIP);
            this.pServerSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pServerSettings.Location = new System.Drawing.Point(0, 0);
            this.pServerSettings.Name = "pServerSettings";
            this.pServerSettings.Size = new System.Drawing.Size(1651, 412);
            this.pServerSettings.TabIndex = 12;
            this.pServerSettings.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(408, 332);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 50);
            this.btnClose.TabIndex = 133;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label3.Location = new System.Drawing.Point(45, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 132;
            this.label3.Text = "Password:";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbPass.Location = new System.Drawing.Point(194, 275);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(332, 30);
            this.tbPass.TabIndex = 131;
            this.tbPass.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label2.Location = new System.Drawing.Point(45, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 130;
            this.label2.Text = "Username:";
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbUser.Location = new System.Drawing.Point(194, 225);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(332, 30);
            this.tbUser.TabIndex = 129;
            this.tbUser.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(45, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 128;
            this.label1.Text = "DB Name:";
            // 
            // tbDB
            // 
            this.tbDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbDB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbDB.Location = new System.Drawing.Point(194, 175);
            this.tbDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(332, 30);
            this.tbDB.TabIndex = 127;
            this.tbDB.Text = "Media Bazaar";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label37.Location = new System.Drawing.Point(44, 42);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(271, 36);
            this.label37.TabIndex = 126;
            this.label37.Text = "Server Credentials";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.label6.Location = new System.Drawing.Point(45, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 125;
            this.label6.Text = "Server IP:";
            // 
            // tbIP
            // 
            this.tbIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tbIP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbIP.Location = new System.Drawing.Point(194, 125);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(332, 30);
            this.tbIP.TabIndex = 124;
            this.tbIP.Text = "192.168.0.37";
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.Location = new System.Drawing.Point(0, 0);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(258, 258);
            this.btnAccount.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1909, 1041);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.Scroller);
            this.Controls.Add(this.SidePanel);
            this.MinimumSize = new System.Drawing.Size(1358, 706);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.pSubmenuAnnoucements.ResumeLayout(false);
            this.pSubmenuInventory.ResumeLayout(false);
            this.pSubmenuLocations.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTab)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.pServerSettings.ResumeLayout(false);
            this.pServerSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel Scroller;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainPanel;
        public AccountButton btnAccount;
        private System.Windows.Forms.Panel pSubmenuAnnoucements;
        private System.Windows.Forms.Button btnAnnoucements;
        private System.Windows.Forms.Panel pSubmenuInventory;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pSubmenuLocations;
        private System.Windows.Forms.Button btnNewLocation;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel pt;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel pb;
        private System.Windows.Forms.Button btnNewAnnoucement;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Button btnServerSettings;
        private System.Windows.Forms.Panel pServerSettings;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTabName;
        private System.Windows.Forms.PictureBox picBoxTab;
    }
}

