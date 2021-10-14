using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES15_GEOMETRIC.CLASSES
{
    class Rect2: Rectangle
    {
        public Rect2(int a, int b) : base(a, b)
        {

        }
        public new int Area()
        {
            return base.Area();
        }
    }
}
