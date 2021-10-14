using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES15_GEOMETRIC.CLASSES;
namespace ES15_GEOMETRIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            var r = new CLASSES.Rect2(4, 6);
            MessageBox.Show(r.Area().ToString());
            LoadList(r);
        }
        private void LoadList( Poligon p)
        {
            lsbShapes.Items.Add($"You added {p.GetType()} with an area of {p.Area()} and perimeter {p.Perimeter()}");
        }
    }
}
