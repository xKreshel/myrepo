using Factory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Entities
{
    class Present : Toy
    {
        public SolidBrush PresentColor { get; private set; }
        public SolidBrush PresentColor2 { get; private set; }
        public Present(Color ribbon, Color box)
        {
            PresentColor = new SolidBrush(ribbon);
            PresentColor2 = new SolidBrush(box);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PresentColor2, 0, 0, Width, Height);
            g.FillRectangle(PresentColor, 20, 0, Width / 4, Height);
            g.FillRectangle(PresentColor, 0, 20, Width, Height / 4);
        }
    }
}
