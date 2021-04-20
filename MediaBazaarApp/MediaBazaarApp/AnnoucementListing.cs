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
    public partial class AnnoucementListing : UserControl
    {
        public AnnoucementListing()
        {
            InitializeComponent();
        }

        public void LoadLayout(EmployeeJob from, string subject, string content, string store, DateTime date)
        {
            lblSubject.Text = subject;
            lblContent.Text = content;
            lblLocation.Text = "Loaction: " + store;
            lblSentByDate.Text = $"{date} from {from}";
        }

        private void AllControls_Enter(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void AllControls_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void BtnMarkRead_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
