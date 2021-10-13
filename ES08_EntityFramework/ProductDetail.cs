using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES08_EntityFramework
{
    public partial class ProductDetail : Form
    {
        
        private Product p;
        private Category cat;
        public ProductDetail( Product p,  Category cat)
        {
            this.p = p;
            this.cat = cat;
            InitializeComponent();
        }

        private void InitFields(object sender, EventArgs e)
        {
           
            LoadCats();
            ProductID.Text = p.ProductID.ToString();
            ProductID.ReadOnly = true;
            ProductName.Text = p.ProductName;
            cmbCats.SelectedIndex = cmbCats.FindStringExact(cat.CategoryName);

        }
        private void LoadCats()
        {
            var db = new NorthwindEntities();
            var cats = db.Categories.ToList();

            cmbCats.DataSource = cats;
            cmbCats.DisplayMember = "CategoryName";
            cmbCats.ValueMember = "CategoryID";
           
        }
    }
}
