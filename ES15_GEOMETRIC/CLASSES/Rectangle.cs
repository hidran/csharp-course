using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES15_GEOMETRIC.CLASSES
{
    class Rectangle : Poligon
    {
        public Rectangle(int a, int b)
        {
            Base = a;
            Height = b;
        }
        public override int Area()
        {
            return Base * Height;
        }


        public override  int Perimeter()
        {
            return (Base + Height) * 2;
        }

       
    }
}
