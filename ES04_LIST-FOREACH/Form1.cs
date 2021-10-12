using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES04_LIST_FOREACH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadList(object sender, EventArgs e)
        {
            lbxCities.Items.Add("Roma");
            lbxCities.Items.Add("Torino");
            lbxCities.Items.Add("Napoli");
        }

        private void AddCity_Click(object sender, EventArgs e)
        {

        }

        private void addRight_Click(object sender, EventArgs e)
        {
           
            if (lbxCities.SelectedIndex == -1)
            {
                return;
            }
            List<object> eles = new List<object>();
            foreach (var ele in lbxCities.SelectedItems)
            {
                eles.Add(ele);
                lbxSelectedCities.Items.Add(ele);
            }
            
             foreach(var o in eles)
            {
                lbxCities.Items.Remove(o);
            }
              
            
            

            
            
        }



        private void AddLeft_Click(object sender, EventArgs e)
        {
            if (lbxSelectedCities.SelectedIndex == -1)
            {
                return;
            }
          
            var eles = new List<object>();
            foreach (var Item in lbxSelectedCities.SelectedItems)
            {
                eles.Add(Item);
                lbxCities.Items.Add(Item);

            }

            foreach (var o in eles)
            {
                lbxSelectedCities.Items.Remove(o);
            }

        }

        private void AddAllRight_Click(object sender, EventArgs e)
        {
            while (lbxCities.Items.Count > 0)
            {
                lbxCities.SelectedIndex = 0;
                addRight_Click(sender, e);
            }
        }

        private void btnAddAllLeft_Click(object sender, EventArgs e)
        {
            while (lbxCities.Items.Count > 0)
            {
                lbxCities.SelectedIndex = 0;
                AddLeft_Click(sender, e);
            }
        }
    }
}
