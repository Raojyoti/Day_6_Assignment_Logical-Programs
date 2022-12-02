using System;
using System.Runtime.InteropServices;

namespace Coupon_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            CouponNum.num = Convert.ToInt32(Console.ReadLine());
            CouponNum.CoupNumber();
        }
    }
}
