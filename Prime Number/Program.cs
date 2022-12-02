/* Check Prime Number or not */

using System;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, count=0;
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            { 
                Console.WriteLine(num + " is prime number");
            }
            else 
            { 
                Console.WriteLine(num + " is not prime number");
            }
            
        }
    }
}
