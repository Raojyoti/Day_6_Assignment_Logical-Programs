using System;
using System.Diagnostics;
using System.Threading;

namespace Simulate_Stopwatch_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();   
            stopwatch.Start(); 
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(10);
            }

            stopwatch.Stop(); 

            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
    
}
