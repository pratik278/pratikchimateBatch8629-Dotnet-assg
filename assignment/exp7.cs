
//Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter 1st number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 3rd number");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Result of specified number {0},{1},{2},(x+y).Z is:{3} and x.y+y.z is {4}", num1, num2, num3, ((num1 + num2) * num3), (num1 * num2 + num2 * num3));
            Console.ReadLine();

        }
    }
}