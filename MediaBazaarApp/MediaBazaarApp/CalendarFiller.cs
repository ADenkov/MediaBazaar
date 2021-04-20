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
    public partial class CalendarFiller : UserControl
    {
        private ConnectSQL cnn;
        private DashboardForm dbf;
        private Employee EMP { get; set; }
        private DateTime Day { get; set; }
        private string TOD { get; set; }

        public CalendarFiller()
        {
            InitializeComponent();
        }

        public void LoadLayout(ConnectSQL cnn, DateTime day, Employee employee, string tod, DashboardForm dbf)
        {
            this.cnn = cnn;
            this.dbf = dbf;
            EMP = employee;
            Day = day;
            TOD = tod;
            lblName.Text = $"{EMP.First} {EMP.Last.Remove(1).ToUpper()}.";
        }

        private void AllControls_Enter(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void AllControls_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void AllControls_Click(object sender, EventArgs e)
        {
            Form cd = new ChangeSchedule(cnn, EMP, Day, TOD, dbf);
            cd.Show();
        }
    }
}
