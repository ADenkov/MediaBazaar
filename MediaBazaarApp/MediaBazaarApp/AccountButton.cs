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
    public partial class AccountButton : UserControl
    {
        private MainForm mf;
        private bool active;

        public AccountButton()
        {
            InitializeComponent();
        }

        public void LoadProfile(string first, string last, Image image, MainForm mf)
        {
            lblAccountHolder.Text = $"{first} {last}";
            profilePicture.Image = image;
            this.mf = mf;
        }

        public void Deselected()
        {
            this.BackColor = Color.FromArgb(40, 44, 55);
            lblAccountHolder.BackColor = Color.FromArgb(40, 44, 55);
            active = false;
        }

        public void Selected()
        {
            BackColor = Color.FromArgb(31, 34, 43);
            lblAccountHolder.BackColor = Color.FromArgb(31, 34, 43);
            active = true;
        }

        private void MouseEnter_AllControls(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(49, 53, 66);
            lblAccountHolder.BackColor = Color.FromArgb(49, 53, 66);
        }

        public void MouseLeave_AllControls(object sender, EventArgs e)
        {
            if (active)
                Selected();
            else
                Deselected();
        }

        private void ControlsClick_Click(object sender, EventArgs e)
        {
            mf.ChangeActivePanel(true);
        }
    }
}
