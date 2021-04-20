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

    public partial class NewProductFrom : Form
    {

        int mov;
        int movX;
        int movY;
        public NewProductFrom()
        {
            InitializeComponent();
        }

        private void NewProductFrom_Load(object sender, EventArgs e)
        {

        }

        private void PanelAnnouncement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewProductFrom_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void NewProductFrom_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void NewProductFrom_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
