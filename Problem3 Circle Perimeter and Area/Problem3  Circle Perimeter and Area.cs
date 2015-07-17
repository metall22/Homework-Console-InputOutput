using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Circle_Perimeter_and_Area
{
    class Perimeter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle's radius:");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI*(r * r);
            double perim = Math.PI * (2 * r);
            Console.WriteLine("The perimeter of the circle is{0:0.00}\nTHe area of the circle is {1:0.00}", perim, area);
        }
    }
}
