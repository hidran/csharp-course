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
    public partial class NorthWind : Form
    {
        public NorthWind()
        {
            InitializeComponent();
        }

     

        private void LoadCategories_Clic(object sender, EventArgs e)
        {
            LoadProducts();

        }

        private void LoadProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadCats(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            var cats = db.Categories.ToList();
           
            cmbCats.DataSource = cats;
            cmbCats.DisplayMember = "CategoryName";
            cmbCats.ValueMember = "CategoryID";
            LoadProducts();
        }
        private void LoadProducts()
        {
            var db = new NorthwindEntities();
            var query = from c in db.Categories
                        join p in db.Products
on c.CategoryID equals p.CategoryID
                        select new { p.ProductID, p.ProductName, p.UnitPrice, c.CategoryName, c.CategoryID };
           
            if(cmbCats.SelectedItem != null)
            {
                var item = cmbCats.SelectedValue;
                
                
          //      MessageBox.Show(cmbCats.SelectedValue.ToString());
                int cat ;

                if (int.TryParse(cmbCats.SelectedValue.ToString(),out cat))
                {
                    query = query.Where(p => p.CategoryID == cat);
                }
               
              
               

            } 
            dtgProducts.DataSource = query.ToList();

        }

        private void ShowFormDetail(object sender, EventArgs e)
        {
          
        }

        private void UpdateProduct(object sender, DataGridViewCellEventArgs e)
        {
            var p = dtgProducts.Rows[e.RowIndex].DataBoundItem;
            MessageBox.Show(p.GetType().GetProperty("ProductName").GetValue(p,null).ToString());
            var product = new Product();
            product.ProductName = p.GetType().GetProperty("ProductName").GetValue(p, null).ToString();
            product.ProductID = (int)p.GetType().GetProperty("ProductID").GetValue(p, null);
            product.CategoryID = (int)p.GetType().GetProperty("CategoryID").GetValue(p, null);
            var db = new NorthwindEntities();
           var cat = db.Categories.Where(el => el.CategoryID == product.CategoryID).First();
            MessageBox.Show(p.ToString());
              p.ToString();
            var f = new ProductDetail(product, cat);
            f.Show();
        }
    }
}
