using System;

namespace Swap_Nibbles_Number
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int n = 100;
            int result = Swap.SwapNibbles(n);
            Console.WriteLine("Original number: " + n +"  "+ "Swapped number: " + result);
        }
    }
}
