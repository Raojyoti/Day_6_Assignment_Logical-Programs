/*   Fibonacci Series */

using System;

namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 1;
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<=num; i++)
            {
                a = b;
                b = c;
                c = a + b;
       
                Console.WriteLine(a );
            }
        }
    }
}
