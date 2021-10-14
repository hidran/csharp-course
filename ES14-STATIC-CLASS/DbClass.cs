using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES14_STATIC_CLASS
{
    public static class DbClass
    {
        public static DataTable GetData(string query)
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable GetDataByParamId(string query, string param, string val)
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue(param, val);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private static string strConn
        {
            get
            {
                return "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            }
        }
        public static DataTable GetProducts()
        {
           
            return GetData("SELECT * FROM PRODUCTS");

        }
        public static DataTable GetProduct(int CatId)
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCTS where CategoryID=@cat", conn);
            cmd.Parameters.AddWithValue("@cat", CatId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Product");
            da.Fill(dt);
            return dt;

        }
        public static DataTable GetCats()
        {
            string sql = "SELECT CategoryID,CategoryName FROM Categories Order by CategoryName";
            return GetData(sql);
           

        }
        public static DataTable GetCountries()
        {
            string sql = "SELECT distinct Country from Customers order by Country";
            return GetData(sql);


        }
        public static DataTable GetCustomers()
        {
            NorthwindEntities db = new NorthwindEntities();
           //var list =  db.Customers.ToList();
            
            string sql = "SELECT * from Customers ";
           
            return GetData(sql);


        }
        public static IEnumerable<Customer> GetCustomerList()
        {
            NorthwindEntities db = new NorthwindEntities();
            var list = db.Customers;

            return list;


        }
        public static DataTable GetCustomersByCountry(string countryId)
        {
            string sql = "SELECT * from customers where Country=@countryId";

            return GetDataByParamId(sql, "countryId", countryId);


        }
    }
}
