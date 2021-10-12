using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES05_Class_Library
{
  public  class Employee: Person
    {
        public enum Titles
        {
            Employee,
            Driver,
            Manager,
            Secretary
        }
        public int Salary { get; set; }
        public Titles Title { get; set; }
        public Employee(string name, string lastname, int yob, int salary) :base(name, lastname, yob)
        {
            this.Salary = salary;
        }
    
    }
}
