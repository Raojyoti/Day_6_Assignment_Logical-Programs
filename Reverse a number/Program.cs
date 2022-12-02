/*  C# program for Reverse the number */

using System;

namespace Reverse_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, remainder, reverse = 0;
            Console.Write("Enter the number: ");
             number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                remainder = number % 10;
                number = number / 10;
               reverse = (reverse * 10) + remainder;

            }
            Console.WriteLine("Reverse number is : "+ reverse);
        }
    }
}
