
//Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter 1st Number:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd Number:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 3rd Number:");
            num3 = int.Parse(Console.ReadLine());
            int Result = num1 * num2 * num3;
            Console.WriteLine("Output:{0}x{1}x{2}={3}", num1, num2, num3, Result);
            Console.ReadLine();

        }
    }
}