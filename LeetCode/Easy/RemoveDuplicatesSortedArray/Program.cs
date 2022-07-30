using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class program
    {
        static void Main(string[] args)
        {

            int[] data = {
        54,
        12,
        65,
        22,
        76,
        77,
        98,
        65
      };

            //print the original array 
            foreach (var x in data)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine();
            RemoveDuplicates(data);
            Console.ReadKey();
        }

    
        private static void RemoveDuplicates(int[] nums)
        {
            Array.Sort(nums);
            int j = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                    nums[j++] = nums[i];
            }

            // removing the duplicate value
            nums[j++] = nums[nums.Length - 1];

            //Print the array
            Console.WriteLine("After removingt he duplicate value");
            for (int x = 0; x < j; x++)
            {
                Console.Write(nums[x] + " ");
            }
        }
    }
}