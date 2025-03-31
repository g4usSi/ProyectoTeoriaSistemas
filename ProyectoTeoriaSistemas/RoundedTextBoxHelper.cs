using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas
{
    public static class RoundedTextBoxHelper
    {
        public static void RoundTextBox(TextBox textBox, int borderRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(textBox.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(textBox.Width - borderRadius, textBox.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, textBox.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            textBox.Region = new Region(path);
        }
    }
}
