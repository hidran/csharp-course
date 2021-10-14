using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES13_ASYNC_AWAIT
{
    public partial class AsyncAwait : Form
    {
        public AsyncAwait()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ini = DateTime.Now;
            txtIni.Text = ini.ToLongTimeString();
            string s = "";
            for(int x=0; x <100000; x++)
            {
                s += x.ToString();
            }
            txtEnd.Text = s.Length.ToString();
            txtTotal.Text = (DateTime.Now - ini).ToString();
        }

        private void AsyncAwait_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime ini = DateTime.Now;
            txtIniBuild.Text = ini.ToLongTimeString();
            StringBuilder s = new StringBuilder("");
            for (int x = 0; x < 100000; x++)
            {
                s.Append(x.ToString());
            }
            txtLengthBuild.Text = s.Length.ToString();
            txtResultBuild.Text = (DateTime.Now - ini).ToString();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            DateTime ini = DateTime.Now;
            txtAsyncIni.Text = ini.ToLongTimeString();
            string s = "";
            Task<string> tsk = (Task<string>)Task.Run(
                () =>
            {
                for (int x = 0; x < 100000; x++)
                {
                    s += x.ToString();
                }
                return s.Length.ToString();
            });
            txtAsyncEnd.Text = await tsk;
            txtAsyncResult.Text = (DateTime.Now - ini).ToString();
        }
    }
}
