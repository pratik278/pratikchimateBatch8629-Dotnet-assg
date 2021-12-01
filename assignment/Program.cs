using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_11
{
    class Class1
    {
        public static void Main(string[]args)
        {

            int x, y;
            Console.WriteLine("Enter 1st Number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            Console.ReadLine();


        }
    }
}