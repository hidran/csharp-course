using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ES_03_Alignment
{
    public partial class UserControl1: UserControl
    {
        string alignment;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SetAlignment(object sender, EventArgs e)
        {
            alignment = ((RadioButton)sender).Text.Replace("rdb", "");
            switch (alignment)
            {
                
                case "Left":
                    csharp.TextAlign = ContentAlignment.TopLeft;
                    break;
                case "Middle":
                    csharp.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                case "Right":
                    csharp.TextAlign = ContentAlignment.MiddleRight;
                    break;
                default:
                    break;
            }
           
        }

        private void rdbMiddle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
