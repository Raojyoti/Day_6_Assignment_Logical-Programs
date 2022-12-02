using System;
using System.Collections.Generic;
using System.Text;

namespace Newton_s_method
{
    internal class NewtonMethod
    {
        public static double c, epsilon= epsilon = 1e-15, root, count = 0, t=c;
        public static void Sqrt()
        {
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine(t);
        }
    }
}
