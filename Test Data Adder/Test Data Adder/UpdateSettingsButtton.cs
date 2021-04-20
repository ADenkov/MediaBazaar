using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Data_Adder
{
    class UpdateSettingsButtton : Button
    {
        public UpdateSettingsButtton()
        {
            BackColor = Color.OrangeRed;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF r = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath graphPath = GetRoundPath(r, 50);

            this.Region = new Region(graphPath);
            using (Pen p = new Pen(Color.OrangeRed, 1.75f))
            {
                p.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(p, graphPath);
            }
        }

        private GraphicsPath GetRoundPath(RectangleF rectangle, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath graphPath = new GraphicsPath();

            graphPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphPath.AddLine(rectangle.X + r2, rectangle.Y, rectangle.Width - r2, rectangle.Y);
            graphPath.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphPath.AddLine(rectangle.Width, rectangle.Y + r2, rectangle.Width, rectangle.Height - r2);
            graphPath.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0, 90);
            graphPath.AddLine(rectangle.Width - r2, rectangle.Height, rectangle.X + r2, rectangle.Height);
            graphPath.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90, 90);
            graphPath.AddLine(rectangle.X, rectangle.Height - r2, rectangle.X, rectangle.Y + r2);

            graphPath.CloseFigure();
            return graphPath;
        }
    }
}
