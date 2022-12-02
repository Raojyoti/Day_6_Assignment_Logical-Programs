using System;

namespace Decimal_to_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Binary.DecToBinary(n);
  
        }
    }
}
