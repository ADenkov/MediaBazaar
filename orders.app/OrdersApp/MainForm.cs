using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersApp
{
    public partial class MainForm : Form
    {
        private Form form;
        private Button selectedBtn;
        private bool mouseDown;
        private Point lastLocation;
        private static ConnectSQL cnn;
        public MainForm()
        {
            InitializeComponent();
            cnn = new ConnectSQL("89.157.247.62", "Media Bazaar", "admin", "admin");
        }

        private void OpenForm(Form f)
        {
            if (form != null)
                form.Close();
            this.form = f;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.BringToFront();
            f.Show();
        }

        // Scroller handling
        private void ScrollerControl()
        {
            if (selectedBtn != null)
            {
                scroller.BringToFront();
                scroller.Visible = true;
                scroller.Location = new Point(0, selectedBtn.Location.Y);
            }
            else
            {
                scroller.Visible = false;
            }
        }

        private void BtnCustomers_MouseEnter(object sender, EventArgs e)
        {
            ScrollerControl();
        }

        private void BtnCustomers_MouseLeave(object sender, EventArgs e)
        {
            selectedBtn = null;
            ScrollerControl();
        }

        private void BtnOrders_MouseEnter(object sender, EventArgs e)
        {
            selectedBtn = btnOrders;
            ScrollerControl();
        }

        private void BtnOrders_MouseLeave(object sender, EventArgs e)
        {
            selectedBtn = null;
            ScrollerControl();
        }

        private void BtnManagement_MouseEnter(object sender, EventArgs e)
        {
            selectedBtn = btnManagement;
            ScrollerControl();
        }

        private void BtnManagement_MouseLeave(object sender, EventArgs e)
        {
            selectedBtn = null;
            ScrollerControl();
        }

        private void RoundButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductsTab(cnn));
        }

        private void BtnManagement_Click(object sender, EventArgs e)
        {
            OpenForm(new ManagementTab(cnn));
        }

        private void RoundButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
