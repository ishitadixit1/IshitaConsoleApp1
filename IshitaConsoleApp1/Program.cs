using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshitaConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the first number :");
            double firstnum= Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the second number :");
            double secondnum = Convert.ToDouble(Console.ReadLine());
            double sum = firstnum + secondnum;
            Console.WriteLine($"The sum of {firstnum} and {secondnum} is: {sum}");

        }
    }
}
