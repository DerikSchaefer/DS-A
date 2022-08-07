using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDuplicates
{
    internal class ContainsDuplicate
    {

        //    int[] nums = { 1, 43, 87, 5, 7, 865, 3, 2, 4, 14 };

        // int[] nums sorted = { 1, 2, 3, 5, 7, 14, 43, 43, 87, 865 }


        public bool checkIt(int[] nums)
        {

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    Console.WriteLine(true);
                    Console.ReadLine();
                    return true;                  
                }
            }
            Console.WriteLine(false);
            Console.ReadLine();
            return false;
           
        }
    }
}


// With this solution, if there were duplicate numbers they would be next to each other so we only need to loop through the array once to determine if 
// there are duplicates. 

/*Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    Input: nums = [1, 2, 3, 1]
Output: true*/