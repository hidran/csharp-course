using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
    public partial class Orders : Form
    {
        protected NorthwindEntities db;
        public Orders()
        {
            InitializeComponent();
            this.db = new NorthwindEntities();
            dtFrom.CustomFormat = "Y-m-d";
            dtTo.CustomFormat = "Y-m-d";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadData(object sender, EventArgs e)
        {
            dtgOrders.DataSource = this.db.Orders.ToList();
        }

        private void FilterOrders(object sender, EventArgs e)
        {
            //  MessageBox.Show(dtFrom.Value.ToUniversalTime());

            string dateini = dtFrom.Value.Day.ToString();
            MessageBox.Show(dateini);

         dtgOrders.DataSource=   this.db.Orders.Where(p => p.OrderDate >= dtFrom.Value).Where(p => p.OrderDate <= dtTo.Value).ToList();
        }
    }
}
