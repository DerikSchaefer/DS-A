using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumber
{
    internal class Single
    {

            public int SingleNumb(int[] nums)
            {

            // Just testing for edge cases
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }


            // Sorting the array, this is crucial for this to work
            Array.Sort(nums);


            // The i += 2 will make sense in a sec
            for (int i = 0; i < nums.Length; i += 2)
            {

                // This if statement will only trigger if we get to the last element of the array & haven't returned yet. 
                // Since it's a sorted array if that were to happen that would be the non-duplicate
                if (i == nums.Length - 1)
                {
                    return nums[i];

                    // the array is sorted and each non-duplicate number will appear exactly twice as per the constraints
                    // so we're comparing them in 'chunks' of two and then the i += 2 is to skip to the next chunk to compare. 

                }
                else if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            return 0;
        }
    }


/*Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.*/
/*
Input: nums = [4, 1, 2, 1, 2]
Output: 4*/