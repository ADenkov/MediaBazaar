using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class EmployeeListing : UserControl
    {
        private LocationsForm lf;
        public string ID { get; private set; }

        public EmployeeListing()
        {
            InitializeComponent();
        }

        public void LoadLayout(string first, string last, string ID, EmployeeJob job, string email, int phone, Image image, LocationsForm lf)
        {
            lblFirstLast.Text = $"{first} {last.Remove(1)}.";
            lblEmployeeID.Text = ID;
            this.ID = ID;
            lblDepartment.Text = job.ToString();
            lblEmail.Text = email;
            lblPhone.Text = "+" + phone.ToString();
            profilePicture.Image = image;
            this.lf = lf;
        }

        private void ControlsEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void ControlsLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void AllControls_Click(object sender, EventArgs e)
        {
            lf.LoadProfile(this);
        }
    }
}
