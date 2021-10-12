using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES05_Class_Library
{
    public class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        private int BirthYear;

        public Person()
        {
            Name = "";
            Lastname = "";
        }
        public Person(string name, string lastname, int yearofbirth)
        {
            Name = name;
            Lastname = lastname;
            YearOfBirth = yearofbirth;
        }
        public int YearOfBirth
        {
            get { return BirthYear; }

            set { if(value>1900) BirthYear = value; }
        }
        public int Age()
        {
            return DateTime.Now.Year - BirthYear;
        }
        public int Age(int age)
        {
            return DateTime.Now.Year - age;
        }
    }
}
