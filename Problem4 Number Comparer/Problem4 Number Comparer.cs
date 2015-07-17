using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_Number_Comparer
{
    class NumberCompare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two numbers");

            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("The bigger number:"+(Math.Max(number1, number2)));
        }
    }
}
