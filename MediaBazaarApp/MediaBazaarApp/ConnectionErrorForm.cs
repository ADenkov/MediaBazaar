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
    public partial class ConnectionErrorForm : Form
    {
        private SendEmailToEnableDB help;
        private ConnectSQL cnn;

        public ConnectionErrorForm(ConnectSQL cnn, string message)
        {
            InitializeComponent();
            this.cnn = cnn;
            lblMessage.Text = message;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text != "" && tbEmail.Text.Contains('@'))
            {
                help = new SendEmailToEnableDB(tbEmail.Text, cnn.IP, cnn.DB, cnn.User, cnn.Pass, tbNote.Text);
                Close();
                MessageBox.Show("An email has been sent to the project team. We will get in toch with you shortly.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
