﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDupsSortedArray
{
    internal class RemoveDups
    {


        public int RemoveDuplicates(int[] nums)
        {


            if (nums.Length == 0)
            {
                return 0;
            }

            int previous = nums[0];
            int currentIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (previous != nums[i])
                {
                    currentIndex++;
                    nums[currentIndex ] = nums[i];
                    previous = nums[i];
                }
            }
            return currentIndex + 1;


        }
        


    }
}
