using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int n = digits.Length - 1;

            for (int i = n; i >= 0; i--)
            {
                // We're looking for the first (from the end) digit that isn't a nine. When we find that we're going to increment it by 1 and return. This is the easy case
                // {1, 2, 3, 4} --> {1, 2, 3, 5}
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                // This digits[i] line will just continue to set things to 0s until we hit a non 9 which will trigger the first if statement and increment that number by 1
                digits[i] = 0;
            }
            // If we loop through the whole array and we don't find a digit that isn't 9 that means the whole array is 9s which is the worst case {9, 9, 9} because we need
            // to increase the length of the array now: {9, 9, 9} --> {1, 0, 0, 0}
            // This statement will take care of the case of everything being nines.
            int[] newArray = new int[digits.Length + 1];
            newArray[0]++;
            return newArray;
        }
    }
}
/*Input: digits = [4, 3, 2, 1]
Output: [4,3,2,2]

You are given a*//* large integer represented as an integer array digits, where each digits[i] 
is the ith digit of the integer. The digits are ordered from most significant to least
    significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.*/