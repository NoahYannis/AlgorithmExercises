using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFacultyAlgorithm
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter number of which you want to calculate the faculty: ");

            int result = 0;

            while (result is 0)
            {
                try
                {
                    string numberString = Console.ReadLine();
                    int numberInt = Convert.ToInt32(numberString);

                    int facultyLoop = numberInt;
                    result = numberInt;

                    for (int i = 0; i < facultyLoop; i++)
                    {
                        while (facultyLoop != 1)
                        {
                            result = result * (facultyLoop - 1);
                            facultyLoop--;
                        }
                    }

                    Console.WriteLine($"The faculty of {numberInt} is: {result}.");
                    Console.ReadLine();
                }
                catch (System.FormatException)
                {
                    Console.Write("Please enter a valid number: ");
                } 
            }
        }
    }
}
