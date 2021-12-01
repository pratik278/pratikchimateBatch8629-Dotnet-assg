//Write a C# Sharp program that takes a number as input and print its multiplication table.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, result;
            Console.WriteLine("enter number:");
            num = int.Parse(Console.ReadLine());
            result = num * 0;
            Console.WriteLine("{0}x{1}={2}", num, 0, result);

            result = num * 1;
            Console.WriteLine("{0}x{1}={2}", num, 1, result);
            result = num * 2;
            Console.WriteLine("{0}x{1}={2}", num, 2, result);
            result = num * 3;
            Console.WriteLine("{0}x{1}={2}", num, 3, result);
            result = num * 4;
            Console.WriteLine("{0}x{1}={2}", num, 4, result);
            result = num * 5;
            Console.WriteLine("{0}x{1}={2}", num, 5, result);
            result = num * 6;
            Console.WriteLine("{0}x{1}={2}", num, 6, result);
            result = num * 7;
            Console.WriteLine("{0}x{1}={2}", num, 7, result);
            result = num * 8;
            Console.WriteLine("{0}x{1}={2}", num, 8, result);
            result = num * 9;
            Console.WriteLine("{0}x{1}={2}", num, 9, result);
            result = num * 10;
            Console.WriteLine("{0}x{1}={2}", num, 10, result);
            Console.ReadLine();











        }
    }
}
