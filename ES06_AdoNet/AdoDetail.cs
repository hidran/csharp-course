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

namespace ES06_AdoNet
{
    public partial class AdoDetail : Form
    {
        public AdoDetail()
        {
            InitializeComponent();
        }
        private void FilterCustomerById()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sql = "SELECT * FROM dbo.Customers ";
              
                    sql += " where Country=@country ORDER BY ContactName";
                    cmd.CommandText = sql;
                    
                    cmd.Parameters.AddWithValue("@country", cmbCountries.SelectedItem.ToString());
                
               
                cmd.Connection = cn;
                // string connStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Northwind; Integrated Security= True";


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgProducts.DataSource = dt;
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
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            //cmbCustomers
        }
        private void LoadCustomerCombo()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
               
                string sql = "SELECT  CustomerId,ContactName FROM dbo.Customers order by ContactName ";
               
                  
              
              
                SqlCommand cmd = new SqlCommand(sql, cn);
                // string connStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Northwind; Integrated Security= True";


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCustomers.DataSource = dt;
                cmbCustomers.DisplayMember = "ContactName";
                cmbCustomers.ValueMember = "CustomerId";
               

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
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            //cmbCustomers
        }
        private void LoadCitieCombo()
        {
            if(cmbCountries.SelectedItem == null)
            {
                return;
            }
            cmbCities.Items.Clear();
            cmbCities.SelectedIndex = -1;
            
            
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sql = "SELECT distinct City FROM dbo.Customers  ";
               
                    sql += " WHERE Country=@country";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@country", cmbCountries.SelectedItem.ToString());
                
               

                cmd.Connection = cn;
                // string connStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Northwind; Integrated Security= True";

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    cmbCities.Items.Add(reader[0]);
                }
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
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            //cmbCustomers
        }
        private void LoadCountriesCombo()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sql = "SELECT Distinct Country FROM dbo.Customers order by Country ";

                cmd.CommandText = sql;

                cmd.Connection = cn;
                // string connStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Northwind; Integrated Security= True";

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    cmbCountries.Items.Add(reader[0]);
                }
                reader.Close();
                cn.Close();
                
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
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            //cmbCustomers
        }
        private void AdoDetail_Load(object sender, EventArgs e)
        {
            LoadAllCustomers(sender, e); 
            LoadCustomerCombo();
            LoadCountriesCombo();
           

        }
        private void CityChange(object sender, EventArgs e)
        {
            LoadCustomers( sender,  e);
            LoadCustomerCombo();
        }
        private void LoadCustomers(object sender, EventArgs e)
        {
            LoadCitieCombo();
            LoadCustomerCombo();
            LoadAllCustomers(sender, e);
        }
        private void LoadAllCustomers(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sql = "SELECT * FROM dbo.Customers where 1=1 ";
                cmd.CommandText = sql;
                if (cmbCountries.SelectedItem!= null)
                {
                    sql += " AND Country=@country";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@country", cmbCountries.SelectedItem.ToString());
                }

                if (cmbCities.SelectedItem != null)
                {
                    sql += " AND City=@City";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@City", cmbCities.SelectedItem.ToString());
                }

                cmd.Connection = cn;
                // string connStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Northwind; Integrated Security= True";
             
             
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgProducts.DataSource = dt;
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
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void LoadOrders(object sender, EventArgs e)
        {
           
           
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string sql = "dbo.CustOrdersOrders ";
                   
                     
                        cmd.CommandText = sql;
                        cmd.Parameters.AddWithValue("@CustomerID", cmbCustomers.SelectedValue.ToString());

                cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    // string connStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Northwind; Integrated Security= True";


                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgOrders.DataSource = dt;
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
                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }
            

        }

        private void dtgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RowSelected_Click(object sender, DataGridViewCellEventArgs e)
        {
           string custid = dtgProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbCustomers.SelectedValue = custid;
        }
    }
}
