using System;
using System.Collections.Generic;
using System.Text;

namespace Coupon_Numbers
{
    internal class CouponNum
    {
        public static int num;
        public static string str = "ABCDEFIGHIJKLMNOPQRSTUVWXYZabcdefighjklmnopqrstuvwxyz1230456789";
        static string randomstring = "";
        public static void CoupNumber()
        {
            Random res = new Random();
            for (int i = 0; i < num; i++)
            {
                int x = res.Next(str.Length);
                randomstring = randomstring + str[x];
            }
            Console.WriteLine("Coupon number is: " + randomstring);
        }
    }
}
