using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class MainForm : Form
    {
        private Form panel;
        private static ConnectSQL cnn;
        public static EmployeeProfile ep;
        private AnnoucementCollection ac;
        private Button focus;

        public MainForm()
        {
            InitializeComponent();
            tbUsername.Text = "admin";
            tbPassword.Text = "admin";
            this.AcceptButton = btnLogin;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Control c in SidePanel.Controls)
                if (c.Name != "btnLogin" && c.Name != "pt" && c.Name != "pb" && !(c is TextBox) && c.Name != "btnServerSettings")
                    c.Visible = false;
            foreach (Button b in SidePanel.Controls.OfType<Button>())
                b.Click += new EventHandler(MaintainScrollerFocus);
        }

        public void ChangeColorSheme(string color)
        {
            string r = color.Remove(color.IndexOf(','));
            string g = color.Substring(color.IndexOf(',') + 2);
            string b = color.Substring(color.LastIndexOf(',') + 2);
            g = g.Remove(g.IndexOf(','));
            Scroller.BackColor = Color.FromArgb(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b));
            TopPanel.BackColor = Color.FromArgb(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b));
        }

        private void MaintainScrollerFocus(object sender, EventArgs e)
        {
            if (focus != null)
                Scroller.Location = new Point(0, focus.Location.Y);
        }

        private void EmployeeAccessibility(EmployeeJob type)
        {
            btnDashboard.Visible = true;
            btnAnnoucements.Visible = true;
            if (type == EmployeeJob.ADMINISTRATOR)
            {
                btnLocations.Visible = true;
            }
            else if (type == EmployeeJob.MANAGER)
            {
                btnLocations.Visible = true;
                btnOrders.Visible = false;
                pSubmenuLocations.Height = 36;
            }
            else if (type == EmployeeJob.FLOOR)
            {
                btnInventory.Visible = true;
                btnOrders.Visible = false;
                pSubmenuInventory.Height = 36;
            }
            else if (type == EmployeeJob.WAREHOUSE)
            {
                btnInventory.Visible = true;
            }
            else if (type == EmployeeJob.ALL)
            {
                btnLocations.Visible = true;
                btnInventory.Visible = true;
            }
        }

        private void ColapseSubmenus(int index)
        {
            pSubmenuLocations.Visible = false;
            pSubmenuInventory.Visible = false;
            pSubmenuAnnoucements.Visible = false;
            if (index == 1)
                pSubmenuLocations.Visible = true;
            else if (index == 2)
                pSubmenuInventory.Visible = true;
            else if (index == 3)
                pSubmenuAnnoucements.Visible = true;
        }

        public void ChangeActivePanel(bool IsAccountPanel)
        {
            Scroller.Visible = false;
            ColapseSubmenus(0);
            foreach (Button b in SidePanel.Controls.OfType<Button>())
                b.BackColor = Color.FromArgb(40, 44, 55);
            btnAccount.Deselected();
            if (IsAccountPanel)
            {
                focus = null;
                Scroller.Height = btnAccount.Height;
                Scroller.Location = new Point(0, 0);
                btnAccount.Selected();
                OpenFormOverlay(new AccountForm(ep, this));
                lblTabName.Text = "Account";
                picBoxTab.Visible = true;
                this.picBoxTab.Load("Account.png");
            }
            else
                foreach (Button b in SidePanel.Controls.OfType<Button>())
                    if (b.Focused)
                        if (b.Name != "btnLogin")
                        {
                            Scroller.Height = b.Height;
                            Scroller.Location = new Point(0, b.Location.Y);
                            b.BackColor = Color.FromArgb(31, 34, 43);
                            focus = b;
                        }
            Scroller.Visible = true;
        }

        private void SubmenuButtonChange(int index)
        {
            ColapseSubmenus(0);
            if(index == 0)
            {
                btnLocations.Focus();
                ChangeActivePanel(false);
            }
            else if (index == 1)
            {
                btnInventory.Focus();
                ChangeActivePanel(false);
            }
            else
            {
                btnAnnoucements.Focus();
                ChangeActivePanel(false);
            }
        }

        public void UpdateAccountButton()
        {
            btnAccount.LoadProfile(ep.First, ep.Last, ep.ProfilePic, this);
        }

        private void OpenFormOverlay(Form Panel)
        {
            if (panel != null)
                panel.Close();
            panel = Panel;
            Panel.TopLevel = false;
            Panel.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(Panel);
            MainPanel.Tag = Panel;
            Panel.BringToFront();
            Panel.Show();
        }

        // Mainmenu Buttons

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            switch (btnLogin.Text)
            {
                case "Login":
                    try
                    {
                        cnn = new ConnectSQL(tbIP.Text, tbDB.Text, tbUser.Text, tbPass.Text);
                        ep = new EmployeeProfile(cnn, tbUsername.Text, tbPassword.Text, this);
                        if (ep.Succeeded == true)
                        {
                            btnAccount.LoadProfile(ep.First, ep.Last, ep.ProfilePic, this);
                            btnAccount.Visible = true;
                            EmployeeAccessibility(ep.Role);
                            btnDashboard.Focus();
                            ChangeActivePanel(false);
                            OpenFormOverlay(new DashboardForm(cnn, ep));
                            TopPanel.Visible = true;
                            btnLogin.Text = "Log Out";
                            tbUsername.Visible = false;
                            tbPassword.Visible = false;
                            Scroller.Visible = true;
                            ac = new AnnoucementCollection(cnn, ep, new EmployeeCollection(cnn));
                            btnAnnoucements.Text += $"       {ac.GetAllAnnoucements().Count}";
                            btnInbox.Text += $"                         {ac.GetAllAnnoucements().Count}";
                            pServerSettings.Visible = false;
                            btnServerSettings.Visible = false;
                            lblTabName.Text = "";
                            picBoxTab.Visible = true;
                            lblTabName.Text = "Dashboard";
                            this.picBoxTab.Load("Dashboard.png");
                            this.AcceptButton = null;
                            if (ep.Role != EmployeeJob.ALL) { MessageBox.Show("Hello,\r\nJust a disclaimer, connection speeds may vary. If a tab appears to be not responsive it is because data is being loaded in slowly.", "DISCLAIMER", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        }
                        else if (ep.Succeeded == false)
                            MessageBox.Show("Failed to login. Please check username and password and try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        Form help = new ConnectionErrorForm(cnn, ex.Message);
                        help.Show();
                    }
                    break;
                default:
                    btnLogin.BackColor = Color.FromArgb(40, 44, 55);
                    btnLogin.Text = "Login";
                    foreach (Control c in SidePanel.Controls)
                        if (c.Name != "btnLogin" && c.Name != "pt" && c.Name != "pb" && !(c is TextBox))
                            c.Visible = false;
                    tbUsername.Visible = true;
                    tbPassword.Visible = true;
                    Scroller.Visible = false;
                    pSubmenuAnnoucements.Visible = false;
                    pSubmenuInventory.Visible = false;
                    TopPanel.Visible = false;
                    if (panel != null)
                        panel.Close();
                    btnAnnoucements.Text = "Annoucements";
                    btnInbox.Text = "Inbox";
                    btnServerSettings.Visible = true;
                    //tbUsername.Clear();
                    //tbPassword.Clear();
                    break;
            }
            SidePanel.Focus();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            ChangeActivePanel(false);
            OpenFormOverlay(new DashboardForm(cnn, ep));
            lblTabName.Text = "Dashboard";
            picBoxTab.Visible = true;
            this.picBoxTab.Load("Dashboard.png");
        }

        private void BtnLocations_Click(object sender, EventArgs e)
        {
            ColapseSubmenus(1);
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            ColapseSubmenus(2);
        }

        private void BtnAnnoucements_Click(object sender, EventArgs e)
        {
            ColapseSubmenus(3);
        }

        // Submenu Buttons

        private void BtnGeneral_Click(object sender, EventArgs e)
        {
            SubmenuButtonChange(0);
            OpenFormOverlay(new LocationsForm(cnn, ep));
            lblTabName.Text = "Locations";
            picBoxTab.Visible = true;
            this.picBoxTab.Load("Locations.png");
        }

        private void BtnNewLocation_Click(object sender, EventArgs e)
        {
            SubmenuButtonChange(0);
            OpenFormOverlay(new NewLocationForm(cnn));
            lblTabName.Text = "Locations";
            picBoxTab.Visible = true;
            this.picBoxTab.Load("Locations.png");
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            SubmenuButtonChange(1);
            OpenFormOverlay(new StocksForm(cnn, ep));
            lblTabName.Text = "Inventory";
            picBoxTab.Visible = true;
            this.picBoxTab.Load("Inventory.png");
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            SubmenuButtonChange(1);
            OpenFormOverlay(new OrdersForm(cnn, ep));
            lblTabName.Text = "Inventory";
            picBoxTab.Visible = true;
            this.picBoxTab.Load("Inventory.png");
        }

        private void BtnNewProduct_Click(object sender, EventArgs e)
        {
            SubmenuButtonChange(1);
            OpenFormOverlay(new NewProductForm(cnn, ep));
        }

        private void BtnInbox_Click(object sender, EventArgs e)
        {
            SubmenuButtonChange(3);
            OpenFormOverlay(new AnnoucementsForm(cnn, ep));
            lblTabName.Text = "Announcements";
            picBoxTab.Visible = true;
            this.picBoxTab.Load("Announcements.png");
        }

        private void BtnNewAnnoucement_Click(object sender, EventArgs e)
        {
            SubmenuButtonChange(3);
            OpenFormOverlay(new NewAnnoucementForm(cnn, ep));
            lblTabName.Text = "Announcements";
            picBoxTab.Visible = true;
            this.picBoxTab.Load("Announcements.png");
        }

        private void BtnServerSettings_Click(object sender, EventArgs e)
        {
            pServerSettings.Visible = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            pServerSettings.Visible = false;
        }
    }
}
