using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Test_Data_Adder
{
    public partial class ProfilePicture : UserControl
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(gp);
            base.OnPaint(pe);
        }
    }
}
