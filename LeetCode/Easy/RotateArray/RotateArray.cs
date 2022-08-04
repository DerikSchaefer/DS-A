using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    internal class RotateArray
    {

        //   

        public int[] rotateIt(int[] nums, int k)
        {

            int len = nums.Length;
            int[] copy = new int[len];

            for (int i = 0; i < len; i++)
            {


                // This formula, i + k % len is going to give us the proper index for the entire array
                // index
                // 0   1  2  3  4  5  6  7
                // value
                // 20 30 40 50 60 70 80 90 
                // formula
                // 3  4  5  6  7  8  9  10
                // modulo / new index
                // 3  4  5  6  7  0  1  2

                copy[(i + k) % len] = nums[i]; 
            }

            for (int j = 0; j < len; j++)
            {
                nums[j] = copy[j];
            }
            return nums;
        }
    }
}
/*Given an array, rotate the array to the right by k steps, where k is non-negative

    Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]*/