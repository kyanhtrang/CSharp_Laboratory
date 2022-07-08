using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TimeManagement
{
    public class CircleButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath circle = new GraphicsPath();
            circle.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(circle);
            base.OnPaint(pevent);
        }
    }
}
