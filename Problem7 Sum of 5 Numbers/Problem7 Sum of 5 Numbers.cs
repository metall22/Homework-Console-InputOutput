using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_Sum_of_5_Numbers
{
    class SumOfnumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 5 numbers:");

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());
            double num5 = double.Parse(Console.ReadLine());

            Console.Write( num1 + num2 + num3 + num4 + num5);



        }
    }
}
