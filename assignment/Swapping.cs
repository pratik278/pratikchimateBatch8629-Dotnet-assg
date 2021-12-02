using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("enter 1st number:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number:");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("after Swapping:");
            Console.WriteLine("First Number:" + number1);
            Console.WriteLine("Second Number:" + number2);

            Console.ReadLine();
        }
    }
}