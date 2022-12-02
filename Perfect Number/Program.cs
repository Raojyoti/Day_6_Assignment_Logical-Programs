/*  Perfect Number */
using System;
using System.Diagnostics.CodeAnalysis;

namespace Perfect_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, result;
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            result = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                { 
                    sum = sum + i;
                }
            }
            if (sum == result)
            {
                Console.WriteLine(num + " is perfect number ");
            }
            else
            { 
                Console.WriteLine(num + " is not perfect number "); 
            }
        }
        
    }
}
