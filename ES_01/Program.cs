using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type first number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double sum = number1 + number2;
           
            Console.WriteLine(string.Format("The result is {0}", sum));
           Console.ReadLine();

        }
    }
}
