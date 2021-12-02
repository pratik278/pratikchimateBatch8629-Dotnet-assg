//Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and
// then four times in the next row, with no separation



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);

            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.ReadLine();
        }
    }
}