using System;
using System.Collections.Generic;
using System.Text;

namespace Swap_Nibbles_Number
{
    public class Swap
    {
        public int n,x;
        public static int SwapNibbles(int n)
        {
            int right = (n & 0b00001111);
            right = (right << 4);
            int left = (n & 0b11110000);
            left = (left >> 4);
            return (right | left);
        }

    }
}
