using NyolcadikHet_IZ7TL4.Abstraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyolcadikHet_IZ7TL4.Entities
{
    class Present : Toy
    {
        public SolidBrush box { get; set; }
        public SolidBrush ribbon { get; set; }
        public Present(Color Color1, Color Color2)
        {
            box = new SolidBrush(Color1);
            ribbon= new SolidBrush(Color2);
        }
        protected override void DrawImage(Graphics graphics)
        {
            graphics.FillRectangle(box, 0, 0, Width, Height);
            graphics.FillRectangle(ribbon, 0, (Height / 5) * 2, Width, Height / 5);
            graphics.FillRectangle(ribbon, Width / 5 * 2, 0, Width / 5, Height);
        }
    }
}
