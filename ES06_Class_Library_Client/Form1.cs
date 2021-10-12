using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES05_Class_Library;
namespace ES06_Class_Library_Client
{
    public partial class Form1 : Form
    {
        private List<Employee> empList;
        public Form1()
        {
            var t = new Person();
           //  MessageBox.Show( t.Age(1972).ToString());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             empList = new List<Employee>
            {
                new Employee(name:"Hidran1", yob:1972, lastname:"Arias", salary:7000)
                ,

                new Employee(name:"Hidran2", yob:1978, lastname:"Arias", salary:6000),
                 new Employee(name:"Hidran2", yob:1979, lastname:"Arias", salary:8000)
            }
               ;

            dtgPersons.DataSource = empList;
        }

        private void CreatePerson_Click(object sender, EventArgs e)
        {
            var p = new Person { 
            Name = "Hidran",
            Lastname = "Arias"
            }
                ;
           
            p.YearOfBirth = 1972;
            txtOutput.Text = $"Ciai {p.Name} you were born in  {p.YearOfBirth} and you are {p.Age()} years old";
        }

        private void OrderBySalary_Click(object sender, EventArgs e)
        {
            dtgPersons.DataSource = empList.OrderByDescending(ele => ele.Salary).ToList();
        }

        private void FilterByYear_click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(txtYear.Text);
            dtgPersons.DataSource = empList.Where(ele => ele.YearOfBirth == y).OrderByDescending(ele => ele.Salary).ToList();
        }
    }
}
