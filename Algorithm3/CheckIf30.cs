using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIf30
{
   // Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
    internal class CheckIf30
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");

            string numberString1 = Console.ReadLine();
            int number1 = int.Parse(numberString1);

            Console.Write("Enter second number: ");

            string numberString2 = Console.ReadLine();
            int number2 = int.Parse(numberString2);

            Console.WriteLine  ();
            Console.WriteLine(ReturnIs30(number1, number2));
            Console.ReadKey();
        }

        static bool ReturnIs30(int x, int y)
        {
            if (x is 30 | y is 30 | x + y is 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
