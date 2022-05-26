using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnDifference
{
    // Write a C# Sharp program to get the absolute difference
    // between n and 51. If n is greater than 51 return triple the absolute difference.

    internal class ReturnDifference  
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);

            Console.WriteLine();
            Console.WriteLine(GetDifference(number, 51));
            Console.ReadKey();
        }

        static int GetDifference(int x, int y)
        {
            return x > y ? (x - y) * 3 : y - x;
        }

    }
}
