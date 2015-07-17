using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Formatting_Numbers
{
    class FormatitingNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            
            Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10 :0:00}|",Convert.ToString(a,16),Convert.ToString(a,2).PadLeft(10,'0'),b,c);
                
        }
    }
}
