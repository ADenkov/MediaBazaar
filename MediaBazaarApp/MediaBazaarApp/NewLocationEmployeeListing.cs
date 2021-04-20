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
    public partial class NewLocationEmployeeListing : UserControl
    {
        private EmployeeCollection ec;
        private NewLocationForm nlf;
        private bool focus;
        public string ID { get; private set; }

        public NewLocationEmployeeListing()
        {
            InitializeComponent();
        }

        public void LoadLayout(string first, string last, string ID, string store, EmployeeJob job, EmployeeCollection ec, NewLocationForm nlf)
        {
            lblName.Text = $"{first} {last.Remove(1)}.";
            this.ID = ID;
            lblEmployeeID.Text = ID;
            lblDepartment.Text = job.ToString();
            lblStore.Text = store;
            this.ec = ec;
            this.nlf = nlf;
        }

        private void ControlsEnter(object sender, EventArgs e)
        {
            if(!focus)
                this.BackColor = Color.WhiteSmoke;
        }

        private void ControlsLeave(object sender, EventArgs e)
        {
            if(!focus)
                this.BackColor = Color.White;
        }

        private void ControlsClick_Clicked(object sender, EventArgs e)
        {
            if (!focus)
            {
                BackColor = Color.Silver;
                ec.SetEmployeeByID(lblEmployeeID.Text);
                focus = true;
                nlf.AddEmployee(this);
            }
            else
            {
                this.BackColor = Color.White;
                focus = false;
            }
        }
    }
}
