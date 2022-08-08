using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Solution
    {
        public char[] ReverseString(char[] s)
        {

            int a_pointer = 0;
            int b_pointer = s.Length - 1;

            while (a_pointer <= b_pointer)
            {
                char temp = s[a_pointer];
                s[a_pointer] = s[b_pointer];
                s[b_pointer] = temp;

                a_pointer += 1;
                b_pointer -= 1;
            }
            return s;
        }
    }
}


/*Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.

    Input: s = ["h", "e", "l", "l", "o"]
Output: ["o","l","l","e","h"]*/