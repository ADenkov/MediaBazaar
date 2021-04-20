using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Data_Adder
{
    public partial class List : UserControl
    {
        public List()
        {
            InitializeComponent();
        }

        public void LoadLayout(string pro, string b, string dep, string na, string des, int pri, byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            pbImage.Image = Image.FromStream(ms);
            lblDepartment.Text = dep;
            lblDescription.Text = des;
            lblPrice.Text = pri.ToString("0.00");
            lblProductID.Text = pro;
            lblTitle.Text = b + " - " + na;
        }

        private void HoverIn(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void HoverOut(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void MoreInfoLabel(object sender, MouseEventArgs e)
        {
            Form pi = new ProductInfo(lblProductID.Text, lblDepartment.Text, lblDescription.Text, lblPrice.Text, lblTitle.Text, pbImage.Image);
            pi.Show();
        }
    }
}
