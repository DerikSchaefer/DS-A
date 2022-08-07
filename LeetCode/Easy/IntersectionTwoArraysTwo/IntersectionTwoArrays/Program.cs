using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionTwoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };
  
            solution solution = new solution();

            solution.twoArrays(nums1, nums2);
        }
    }
}
