using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f01_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sayHi(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeColor(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Yellow;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double res = Somma(Convert.ToDouble(value1.Text), Convert.ToDouble(value2.Text));
                result.Text = res.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("valore troppo grande" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error di tipo {ex.GetType()} -messaggio  {  ex.Message}");
            }
        }
        private double Somma(double n1, double n2)
        {
            return n1 + n2;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void executeCalc(object sender, EventArgs e)
        {
            double result = 0;
            try
            {
                double val1 = Convert.ToDouble(txtVal1.Text);
                double val2 = Convert.ToDouble(txtVal2.Text);
                if (rdbSum.Checked)
                {
                    result = Somma(val1, val2);
                }
                else if (rdbMul.Checked)
                {
                    result = val1 * val2;
                }
                else if (rdbSub.Checked)
                {
                    result = val1 - val2;
                }
                else if (rdbDiv.Checked)
                {
                    result = val1 / val2;

                }
                else
                {
                    MessageBox.Show("scegliere operazione");
                }
                txtResult.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("valore troppo grande" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error di tipo {ex.GetType()} -messaggio  {  ex.Message}");
            }
        }
        
    }
}
