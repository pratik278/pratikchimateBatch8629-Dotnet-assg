//Write a C# program to get the absolute value of the difference between two given numbers.
// Return double the absolute value of the difference if the first number is greater than second number.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_11
{
    class Class3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 2));
            Console.WriteLine(Sum(6, 2));
            Console.WriteLine(Sum(-2, 7));
            Console.WriteLine(Sum(-7, 2));
            Console.ReadLine();
        }
        public static int Sum(int a, int b)
        {
            if (a > b)
            {
                return (a - b) * 2;
            }
            return (b - a);
        }
    }
}