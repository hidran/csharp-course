using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
namespace ConsumeApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

       HttpClient     client = new HttpClient();
            HttpResponseMessage res = await client.GetAsync("http://localhost:59818/api/Categories");
            string json = await res.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject(json);
            dtgProducts.DataSource = result;
            MessageBox.Show(json);

        }
    }
}
