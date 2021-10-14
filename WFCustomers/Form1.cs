using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES14_STATIC_CLASS;
namespace WFCustomers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCustomers(object sender, EventArgs e)
        {
            grvCustomers.DataSource = DbClass.GetCustomerList().ToList();
            DataTable dt = DbClass.GetCountries();
            var dr = dt.NewRow();
            dr[0] = "All countries";
            dt.Rows.InsertAt(dr, 0);
            cbCountries.DataSource =dt;
            cbCountries.DisplayMember = "Country";
            cbCountries.ValueMember = "Country";
        }

        private void ReloadGrid(object sender, EventArgs e)
        {
           
            if(cbCountries.SelectedIndex == 0)
            {
                grvCustomers.DataSource = DbClass.GetCustomers();
            } else
            {
                grvCustomers.DataSource = DbClass.GetCustomersByCountry(cbCountries.SelectedValue.ToString());
            }
        }
    }
}
