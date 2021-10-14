using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES15_GEOMETRIC.CLASSES
{
    public abstract class Poligon
    {
        public int Base { get; set; }
        public int Height { get; set; }
        public abstract int Area();
        public abstract int Perimeter();
    }
}
