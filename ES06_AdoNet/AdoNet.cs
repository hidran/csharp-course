using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ES06_AdoNet
{
    public partial class AdoNet : Form
    {
        public AdoNet()
        {
            InitializeComponent();
        }

        private void CaricaProdotto_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

            try
            {
               // string connStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Northwind; Integrated Security= True";
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Products", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataProductsGridView.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($" {ex.Number} {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

        }

        private void ShowDetail_Click(object sender, EventArgs e)
        {
            var f = new AdoDetail();
            f.Show();
        }

        private void AdoNet_Load(object sender, EventArgs e)
        {

        }
    }
}
