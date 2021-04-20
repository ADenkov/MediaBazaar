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
    public partial class NoAnnoucements : UserControl
    {
        private AnnoucementsForm af;

        public NoAnnoucements()
        {
            InitializeComponent();
        }

        public void ActivePanelAnnoucements(AnnoucementsForm af)
        {
            this.af = af;
        }

        private void AllControls_Click(object sender, EventArgs e)
        {
            af.LoadAllAnnoucements();
            if (af.CheckAnnoucements())
                Dispose();
        }

        private void AllControls_Enter(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void AllControls_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
