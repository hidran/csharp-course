using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.dt =  ES14_STATIC_CLASS.DbClass.GetProducts();
            GridView1.DataSource = this.dt;
            totRec.Text = this.dt.Rows.Count.ToString();
            GridView1.DataBind();
            lsbCats.DataTextField = "CategoryName";
            lsbCats.DataValueField = "CategoryID";
            drpCats.DataTextField = "CategoryName";
            drpCats.DataValueField = "CategoryID";
            drpCats.DataSource = ES14_STATIC_CLASS.DbClass.GetCats();
            drpCats.DataBind();
            lsbCats.DataSource = ES14_STATIC_CLASS.DbClass.GetCats();
            lsbCats.DataBind();
          
        }

        protected void LoadData(object sender, EventArgs e)
        {
         //   GridView1.DataSource = ES14_STATIC_CLASS.DbClass.GetProducts(); 

        }

        protected void LoadGRid(object sender, EventArgs e)
        {
            GridView1.DataSource = ES14_STATIC_CLASS.DbClass.GetProduct(Convert.ToInt32(txtCategoryId.Text));
            GridView1.DataBind();
        }

        protected void ReloadGrid(object sender, EventArgs e)
        {
            totRec.Text = lsbCats.SelectedValue;
            GridView1.DataSource = ES14_STATIC_CLASS.DbClass.GetProduct(Convert.ToInt32(drpCats.SelectedValue));
            GridView1.DataBind();
        }
    }
}