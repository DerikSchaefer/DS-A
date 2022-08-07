using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionTwoArrays
{
    internal class solution
    {


        public int[] twoArrays(int[] nums1, int[] nums2)
        {
            int length1 = nums1.Length;
            int length2 = nums2.Length;
            int[] temp = new int[length1 * length2];

            int i = 0, j = 0, k = 0;

            Array.Sort(nums1);
            Array.Sort(nums2);
            // We sorted the arrays. We're comparing if i is less than j, if not we increment i, if i is not less than j we compare if j is less than i and if it is we increment, if not then it
            // moves down because the only other possiblity is that they're equal.
            while (i < length1 && j < length2)
            {
                if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    temp[k++] = nums1[i++];
                    j++;

                }

            }
            int[] result = new int[k];
            Array.Copy(temp, result, k);
            foreach (var val in result)
            {
                Console.WriteLine(val);
                Console.ReadLine();
            }
            return result;
        }
    }
}

/*Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it 
shows in both arrays and you may return the result in any order.*/

/*Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
Output: [4,9]
Explanation: [9,4] is also accepted.*/