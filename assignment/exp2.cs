//Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_11
{
    class Class2
    {
        public static void main(string[] args)
        {
            Console.WriteLine(Sum(2, 2));
            Console.WriteLine(Sum(-3, 2));
            Console.WriteLine(Sum(-6, -6));
            Console.ReadLine();

        }
        public static int Sum(int x, int y)
        {
           // return x == y ? (x + y) * 3 : x + y;
           if(x==y)
            {
                return (x + y) * 3;
            }
            return x + y;
            
        }

    }
}